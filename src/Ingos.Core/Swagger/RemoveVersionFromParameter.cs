//-----------------------------------------------------------------------
// <copyright file= "RemoveVersionFromParameter.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/7/20 21:52:36
// Modified by:
// Description: Remove version param must input in swagger doc
//-----------------------------------------------------------------------
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace Ingos.Core.Swagger
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