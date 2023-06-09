/*
 * IdentityDbContextDesignTimeFactory.cs
 *
 *   Created: 2022-12-19-08:21:27
 *   Modified: 2022-12-19-08:21:27
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022-2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Dgmjr.Identity.EntityFrameworkCore.Migrations;

public class IdentityDbContextDesignTimeFactory : IDesignTimeDbContextFactory<IdentityDbContext>
{
    public const string DefaultConnectionStringKey = "AZURE_APPCONFIGURATION_CONNECTIONSTRING";
    public IdentityDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationManager()
                     .AddUserSecrets<IdentityDbContextDesignTimeFactory>();
        var connectionString = ((IConfigurationRoot)config)[DefaultConnectionStringKey];
        connectionString = config
            .AddAzureAppConfiguration(options =>
                options.Connect(connectionString)
                    .ConfigureKeyVault(kv =>
                        kv.SetCredential(new DefaultAzureCredential())))
            .Build()
            .GetConnectionString("IdentityDb");
        var builder = new DbContextOptionsBuilder<IdentityDbContext>();
        builder.UseSqlServer(connectionString);
        return new IdentityDbContext(builder.Options);
    }
}
