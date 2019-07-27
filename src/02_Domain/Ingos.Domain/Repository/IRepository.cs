//-----------------------------------------------------------------------
// <copyright file= "IRepository.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/7/27 16:58:17
// Modified by:
// Description:
//-----------------------------------------------------------------------
using Ingos.Aggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Domain.Repository
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}