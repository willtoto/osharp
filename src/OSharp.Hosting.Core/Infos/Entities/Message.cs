using Microsoft.EntityFrameworkCore;

namespace OSharp.Hosting.Infos.Entities;

[TableNamePrefix("Infos")]
public partial class Message
{
    /// <summary>
    /// 获取或设置 家庭地址
    /// </summary>
    [DisplayName("家庭地址")]
    public Address HomeAddress { get; set; }
}

[Owned]
public class Address
{
    public string Province { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
}
