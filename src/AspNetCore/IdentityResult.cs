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
    public IdentityResult(
        MSIDR result,
        string? message = null,
        HttpStatus statusCode = InternalServerError
    )
    {
        // new ResponsePayload<IdentityResultTuple<object>>(this, new(result, value));
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
        StatusCode.HasValue && StatusCode.Value >= OK && StatusCode.Value <= (HttpStatus)299;

    [XAttribute("message"), JProp("message"), JIgnore(Condition = JIgnoreCond.WhenWritingNull)]
    public virtual string Message { get; set; }

    [XIgnore, JIgnore]
    public virtual string? StringValue
    {
        get => Message;
        set => Message = value!;
    }

    [JIgnore, XIgnore]
    public virtual HttpStatus? StatusCode { get; set; }

    [JIgnore, XIgnore]
    int? IStatusCodeActionResult.StatusCode => (int?)StatusCode;

    [JProp("result"), JIgnore(Condition = JIgnoreCond.WhenWritingNull), XAttribute("result")]
    public virtual MSIDR Result { get; set; }

    [JProp("value"), JIgnore(Condition = JIgnoreCond.WhenWritingNull), XAttribute("value")]
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

    [JsonIgnore]
    [XIgnore]
    public ICollection<IOutputFormatter> OutputFormatters { get; } = new List<IOutputFormatter>();

    [JsonIgnore]
    [XIgnore]
    public MediaTypeCollection ContentTypes { get; } = new MediaTypeCollection();

    public static IdentityResult Failed(
        HttpStatus statusCode = SC.InternalServerError,
        params IdentityError[] errors
    ) => new(MSIDR.Failed(errors), statusCode: statusCode);

    public static IdentityResult Failed(
        HttpStatus statusCode = SC.InternalServerError,
        params string[] errors
    ) =>
        new(
            MSIDR.Failed(errors.Select(e => new IdentityError { Description = e }).ToArray()),
            statusCode: statusCode
        );

    public static IdentityResult Failed(
        IdentityError error,
        HttpStatus statusCode = SC.InternalServerError
    ) => new(MSIDR.Failed(error), statusCode: statusCode);

    public static IdentityResult Failed(
        string error,
        HttpStatus statusCode = SC.InternalServerError
    ) => new(MSIDR.Failed(new IdentityError { Description = error }), statusCode: statusCode);

    public static IdentityResult Failed(
        MSIDR result,
        HttpStatus statusCode = SC.InternalServerError
    ) => new(result, statusCode: statusCode);

    public static IdentityResult Failed(HttpStatus statusCode = SC.InternalServerError) =>
        new(MSIDR.Failed(), statusCode: statusCode);

    public static IdentityResult Success(string message = "Success", HttpStatus statusCode = OK) =>
        new(MSIDR.Success, message: message, statusCode: statusCode);

    public virtual async Task ExecuteResultAsync(ActionContext context)
    {
        var executor = context.HttpContext.RequestServices.GetRequiredService<
            IActionResultExecutor<IdentityResult>
        >();
        await executor.ExecuteAsync(context, this);
    }

    public virtual void OnFormatting(OutputFormatterWriteContext context)
    {

    }

    // public static implicit operator IdentityResult(MSIDR result) => new(result);

    // public static implicit operator MSIDR?(IdentityResult result) => result?.Result;
}

// public class IdentityResult<TValue> : IdentityResult
// {
//     public IdentityResult(
//         MSIDR result,
//         TValue value,
//         string? message = null,
//         HttpStatus statusCode = SC.InternalServerError
//     )
//         : base(result, value, message, statusCode) { }

//     public static implicit operator IdentityResult<TValue>(MSIDR result) => new(result, default);

//     public new TValue Value => (TValue)base.Value;
// }
