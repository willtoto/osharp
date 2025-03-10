// -----------------------------------------------------------------------
//  <copyright file="LoginLogConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-06-27 4:48</last-date>
// -----------------------------------------------------------------------

using OSharp.Hosting.Identity.Entities;


namespace OSharp.Hosting.EntityConfiguration.Identity;

public partial class LoginLogConfiguration : EntityTypeConfigurationBase<LoginLog, long>
{
    /// <summary>
    /// 重写以实现实体类型各个属性的数据库配置
    /// </summary>
    /// <param name="builder">实体类型创建器</param>
    public override void Configure(EntityTypeBuilder<LoginLog> builder)
    {
        builder.Property(m => m.Id).ValueGeneratedNever();
        builder.HasOne<User>(m => m.User).WithMany().HasForeignKey(m => m.UserId).OnDelete(DeleteBehavior.Cascade);

        EntityConfigurationAppend(builder);
    }

    /// <summary>
    /// 额外的数据映射
    /// </summary>
    partial void EntityConfigurationAppend(EntityTypeBuilder<LoginLog> builder);
}
