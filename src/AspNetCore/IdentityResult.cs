/*
 * IdentityResult.cs
 *
 *   Created: 2022-12-13-10:55:26
 *   Modified: 2022-12-13-10:55:26
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Net;
using static System.Net.HttpStatusCode;
using System.Xml.Serialization;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;

using Azure;

using Dgmjr.Payloads;

using MSIDR = Microsoft.AspNetCore.Identity.IdentityResult;

using HttpStatus = System.Net.HttpStatusCode;

using SC = System.Net.HttpStatusCode;

namespace Dgmjr.Identity;

public class IdentityResult : MSIDR, IResponsePayload<MSIDR>
{
    public IdentityResult(MSIDR result, string? message = null, SC statusCode = InternalServerError)
    {
        Result = result;
        Message = message ?? string.Empty;
        StatusCode = statusCode;
        ContentTypes.Add(new MediaTypeHeaderValue("application/json"));
        ContentTypes.Add(new MediaTypeHeaderValue("application/xml"));
        ContentTypes.Add(new MediaTypeHeaderValue("application/x-msgpack"));
        ContentTypes.Add(new MediaTypeHeaderValue("application/bson"));
        ContentTypes.Add(new MediaTypeHeaderValue("text/plain"));
    }

    [JProp("isSuccess"), XAttribute("isSuccess")]
    public virtual bool IsSuccess =>
        StatusCode.HasValue && StatusCode.Value >= OK && StatusCode.Value <= (SC)299;

    [XAttribute("message"), JProp("message"), JIgnore(Condition = JIgnore.WhenWritingNull)]
    public virtual string Message { get; set; }

    [XIgnore, JIgnore]
    public virtual string? StringValue
    {
        get => Message;
        set => Message = value!;
    }

    [JIgnore, XIgnore]
    public virtual SC? StatusCode { get; set; }

    [JIgnore, XIgnore]
    int? IStatusCodeActionResult.StatusCode => (int?)StatusCode;

    [JProp("result"), JIgnore(Condition = JIgnore.WhenWritingNull), XAttribute("result")]
    public virtual MSIDR Result { get; set; }

    [JProp("value"), JIgnore(Condition = JIgnore.WhenWritingNull), XAttribute("value")]
    public virtual MSIDR? Value
    {
        get => Result;
        set => Result = value;
    }

    [JIgnore, XIgnore]
    object? IPayload.Value
    {
        get => Result;
        set => Result = value as MSIDR;
    }

    [JsonIgnore, XIgnore]
    public ICollection<IOutputFormatter> OutputFormatters { get; } = new List<IOutputFormatter>();

    [JsonIgnore, XIgnore]
    public MediaTypeCollection ContentTypes { get; } = new MediaTypeCollection();

    public static IdentityResult Failed(
        SC statusCode = InternalServerError,
        params IdentityError[] errors
    ) => new(Failed(errors), statusCode: statusCode);

    public static IdentityResult Failed(
        SC statusCode = InternalServerError,
        params string[] errors
    ) =>
        new(
            Failed(errors.Select(e => new IdentityError { Description = e }).ToArray()),
            statusCode: statusCode
        );

    public static IdentityResult Failed(IdentityError error, SC statusCode = InternalServerError) =>
        new(MSIDR.Failed(error), statusCode: statusCode);

    public static IdentityResult Failed(string error, SC statusCode = InternalServerError) =>
        new(MSIDR.Failed(new IdentityError { Description = error }), statusCode: statusCode);

    public static IdentityResult Failed(MSIDR result, SC statusCode = InternalServerError) =>
        new(result, statusCode: statusCode);

    public static IdentityResult Failed(SC statusCode = InternalServerError) =>
        new(MSIDR.Failed(), statusCode: statusCode);

    public static new IdentityResult Success(string message = "Success", SC statusCode = OK) =>
        new(MSIDR.Success, message: message, statusCode: statusCode);

    public virtual async Task ExecuteResultAsync(ActionContext context)
    {
        var executor = context.HttpContext.RequestServices.GetRequiredService<
            IActionResultExecutor<IdentityResult>
        >();
        await executor.ExecuteAsync(context, this);
    }

    public virtual void OnFormatting(OutputFormatterWriteContext context) { }

    // public static implicit operator IdentityResult(MSIDR result) => new(result);

    // public static implicit operator MSIDR?(IdentityResult result) => result?.Result;
}

// public class IdentityResult<TValue> : IdentityResult
// {
//     public IdentityResult(
//         MSIDR result,
//         TValue value,
//         string? message = null,
//         SC statusCode = InternalServerError
//     )
//         : base(result, value, message, statusCode) { }

//     public static implicit operator IdentityResult<TValue>(MSIDR result) => new(result, default);

//     public new TValue Value => (TValue)base.Value;
// }
