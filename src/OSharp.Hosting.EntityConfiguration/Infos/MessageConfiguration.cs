//  <copyright file="MessageConfiguration.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2019 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
// -----------------------------------------------------------------------

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OSharp.Hosting.Infos.Entities;
using System.Text.Json;

namespace OSharp.Hosting.EntityConfiguration.Infos
{
    /// <summary>
    /// 实体配置类：站内信信息扩展配置
    /// </summary>
    public partial class MessageConfiguration
    {
        /// <summary>
        /// 额外的数据映射
        /// </summary>
        partial void EntityConfigurationAppend(EntityTypeBuilder<Message> builder)
        {
            // 创建 Address 到 JSON 字符串的值转换器
            var addressConverter = new ValueConverter<Address, string>(
                v => v == null ? null : JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                v => string.IsNullOrEmpty(v) ? null : JsonSerializer.Deserialize<Address>(v, (JsonSerializerOptions)null),
                new ConverterMappingHints(size: 4000));

            builder.Property(b => b.HomeAddress)
                .HasConversion(addressConverter)
                .HasColumnType("json");
        }
    }
}
