//-----------------------------------------------------------------------
// <copyright file= "RemoveVersionFromParameter.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/7/27 16:38:23
// Modified by:
// Description: Remove version param must input in swagger doc
//-----------------------------------------------------------------------
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace Ingos.Api.Core.Extension.Swagger
{
    public class RemoveVersionFromParameter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            var versionParameter = operation.Parameters.Single(p => p.Name == "version");
            operation.Parameters.Remove(versionParameter);
        }
    }
}