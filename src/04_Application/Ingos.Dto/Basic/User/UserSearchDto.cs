//-----------------------------------------------------------------------
// <copyright file= "UserSearchDto.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2019/7/20 22:20:43
// Modified by:
// Description: User search params model
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Ingos.Dto.Basic.User
{
    public class UserSearchDto
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 账户名称
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public string Email { get; set; }
    }
}