using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liuliu.Demo.MultiTenancy.Dtos;

namespace Liuliu.Demo.MultiTenancy
{
    // 租户访问器接口，用于在作用域内设置当前租户
    public interface ITenantAccessor
    {
        TenantOutputDto CurrentTenant { get; set; }
    }
}
