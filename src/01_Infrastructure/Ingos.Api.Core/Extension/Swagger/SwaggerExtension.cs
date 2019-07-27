//-----------------------------------------------------------------------
// <copyright file= "SwaggerExtension.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/7/27 16:34:40
// Modified by:
// Description: Swagger configuraion's extension method
//-----------------------------------------------------------------------
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Linq;

namespace Ingos.Api.Core.Extension.Swagger
{
    public static class SwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            // Config swagger doc info
            services.AddSwaggerGen(s =>
            {
                // Generate api doc by api version info
                //
                var provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();

                foreach (var description in provider.ApiVersionDescriptions)
                {
                    s.SwaggerDoc(description.GroupName, new Info
                    {
                        Contact = new Contact
                        {
                            Name = "Danvic Wang",
                            Email = "danvic96@hotmail.com",
                            Url = "https://yuiter.com"
                        },
                        Description = "Ingos.API 接口文档",
                        Title = "Ingos.API",
                        Version = description.ApiVersion.ToString()
                    });
                }

                // Show api version in the url which swagger doc generated
                s.DocInclusionPredicate((version, apiDescription) =>
                {
                    if (!version.Equals(apiDescription.GroupName))
                        return false;

                    var values = apiDescription.RelativePath
                        .Split('/')
                        .Select(v => v.Replace("v{version}", apiDescription.GroupName)); apiDescription.RelativePath = string.Join("/", values);
                    return true;
                });

                // Let params use the camel naming method
                s.DescribeAllParametersInCamelCase();

                // Remove version param must input in swagger doc
                s.OperationFilter<RemoveVersionFromParameter>();

                // Get project's api description file
                var basePath = Path.GetDirectoryName(AppContext.BaseDirectory);
                var apiPath = Path.Combine(basePath, "Ingos.Api.xml");
                var dtoPath = Path.Combine(basePath, "Ingos.Application.xml");
                s.IncludeXmlComments(apiPath, true);
                s.IncludeXmlComments(dtoPath, true);
            });
        }
    }
}