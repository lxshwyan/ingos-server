//-----------------------------------------------------------------------
// <copyright file= "IUnitOfWork.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/7/27 16:59:19
// Modified by:
// Description:
//-----------------------------------------------------------------------
using System.Threading;
using System.Threading.Tasks;

namespace Ingos.Domain.Repository
{
    public interface IUnitOfWork
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        ///
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default);
    }
}