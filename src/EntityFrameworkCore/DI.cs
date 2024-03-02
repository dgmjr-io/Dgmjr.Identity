/*
 * DI.cs
 *
 *   Created: 2022-12-20-12:36:48
 *   Modified: 2022-12-20-12:36:48
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;

using System.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using System.Net.Mail;

public static class DescribeDataTypesExtensions
{
    // public static WebApplicationBuilder DescribeIdentityDataTypes(
    //     this WebApplicationBuilder builder
    // )
    // {
    //     builder.Services.DescribeIdentityDataTypes();
    //     return builder;
    // }

    public static IServiceCollection DescribeIdentityDataTypes(this IServiceCollection services)
    {
        services.Describe<EmailAddress>();
        services.Describe<PhoneNumber>();
        // services.ConfigureSwaggerGen(c =>
        // {
        //     c.MapType<EmailAddress>(
        //         () =>
        //             new OpenApiSchema
        //             {
        //                 Type = "string",
        //                 Pattern = EmailAddress.RegexString,
        //                 Format = nameof(EmailAddress),
        //                 Description = EmailAddress.Description,
        //                 Example = new OpenApiString(EmailAddress.ExampleValueString),
        //                 Default = new OpenApiString(EmailAddress.EmptyValueString),
        //                 ExternalDocs = new OpenApiExternalDocs
        //                 {
        //                     Description = "Email Address",
        //                     Url = new("https://en.wikipedia.org/wiki/Email_address")
        //                 }
        //             }
        //     );
        //     c.MapType<PhoneNumber>(
        //         () =>
        //             new OpenApiSchema
        //             {
        //                 Type = "string",
        //                 Pattern = PhoneNumber.RegexString,
        //                 Format = nameof(PhoneNumber),
        //                 Description = PhoneNumber.Description,
        //                 Example = new OpenApiString(PhoneNumber.ExampleString),
        //                 Default = new OpenApiString(PhoneNumber.EmptyString),
        //                 ExternalDocs = new OpenApiExternalDocs
        //                 {
        //                     Description = "E.164",
        //                     Url = new("https://en.wikipedia.org/wiki/E.164")
        //                 }
        //             }
        //     );
        // });
        return services;
    }
}
