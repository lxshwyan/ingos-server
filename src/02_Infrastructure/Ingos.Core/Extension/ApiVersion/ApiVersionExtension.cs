//-----------------------------------------------------------------------
// <copyright file= "ApiVersionExtension.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/7/20 21:55:54
// Modified by:
// Description: Api version extension method
//-----------------------------------------------------------------------
using Microsoft.Extensions.DependencyInjection;

namespace Ingos.Core.Extension.ApiVersion
{
    public static class ApiVersionExtension
    {
        /// <summary>
        /// Add api version support
        /// </summary>
        /// <param name="services">The instance of <see cref="IServiceCollection"/></param>
        public static void AddApiVersion(this IServiceCollection services)
        {
            // Add api version support
            services.AddApiVersioning(o =>
            {
                // return api version info in response header
                o.ReportApiVersions = true;

                // default api version
                o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);

                // when not specifying an api version, select the default version
                o.AssumeDefaultVersionWhenUnspecified = true;
            });

            // Config api version info
            services.AddVersionedApiExplorer(option =>
            {
                // Set api version group name format
                option.GroupNameFormat = "'v'VVVV";

                // when not specifying an api version, select the default version
                option.AssumeDefaultVersionWhenUnspecified = true;
            });
        }
    }
}