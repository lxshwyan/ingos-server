﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ingos.Dto.Basic.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ingos.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : ControllerBase
    {
        #region APIs

        /// <summary>
        /// 获取全部的用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserListDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get()
        {
            // 1、Get resource data

            // 2、Determine if the request was successful
            if (true)
                return Ok(new List<UserListDto>());
            else
                return BadRequest(new
                {
                    statusCode = StatusCodes.Status400BadRequest,
                    description = "The error description",
                    msg = "The detail error message"
                });
        }

        /// <summary>
        /// 根据条件搜索网站用户信息
        /// </summary>
        /// <param name="search">搜索用户信息数据传输对象</param>
        /// <returns></returns>
        [HttpGet("query")]
        [ProducesResponseType(typeof(IEnumerable<UserListDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get([FromQuery]UserSearchDto search)
        {
            return Ok();
        }

        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="edit">用户编辑信息数据传输对象</param>
        [HttpPost]
        [ProducesResponseType(typeof(UserEditDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] UserEditDto edit)
        {
            return Created("", new UserEditDto());
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="id">用户唯一标识</param>
        /// <param name="edit">用户编辑信息数据传输对象</param>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(UserEditDto), StatusCodes.Status404NotFound)]
        public IActionResult Put(string id, [FromBody] UserEditDto edit)
        {
            return Ok();
        }

        /// <summary>
        /// 更新用户状态
        /// </summary>
        /// <param name="id">用户唯一标识</param>
        [HttpPut("{id}/refresh")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(UserEditDto), StatusCodes.Status404NotFound)]
        public IActionResult Put(string id)
        {
            return Ok();
        }

        /// <summary>
        /// 删除用户信息
        /// </summary>
        /// <param name="id">用户唯一标识</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(UserEditDto), StatusCodes.Status404NotFound)]
        public IActionResult Delete(string id)
        {
            return Delete(id);
        }

        #endregion APIs
    }
}