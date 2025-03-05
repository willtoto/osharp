// -----------------------------------------------------------------------
//  <copyright file="RoleStore.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:44</last-date>
// -----------------------------------------------------------------------

using Liuliu.Demo.Identity.Entities;

using OSharp.Entity;
using OSharp.Identity;


namespace Liuliu.Demo.Identity
{
    /// <summary>
    /// 角色仓储
    /// </summary>
    public class RoleStore : RoleStoreBase<Role, long, RoleClaim, long>
    {
        /// <summary>
        /// 初始化一个<see cref="RoleStoreBase{TRole,TRoleKey,TRoleClaim, TRoleClaimKey}"/>类型的新实例
        /// </summary>
        public RoleStore(IRepository<Role, long> roleRepository, IRepository<RoleClaim, long> roleClaimRepository)
            : base(roleRepository, roleClaimRepository)
        { }
    }
}