using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liuliu.Demo.MultiTenancy.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Liuliu.Demo.MultiTenancy
{
    /// <summary>
    /// 多租户中间件，用于在请求处理过程中设置当前租户
    /// </summary>
    public class TenantMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<TenantMiddleware> _logger;

        public TenantMiddleware(
            RequestDelegate next,
            ILogger<TenantMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, ITenantProvider tenantProvider, ITenantAccessor tenantAccessor)
        {
            try
            {
                // 解析当前租户
                TenantOutputDto tenant = tenantProvider.GetCurrentTenant();

                // 设置当前租户到访问器中
                if (tenant != null)
                {
                    tenantAccessor.CurrentTenant = tenant;
                    _logger.LogDebug("已设置当前租户: {TenantKey}, {Name}", tenant.TenantKey, tenant.Name);

                    // 可以在这里添加租户相关的请求头或其他信息
                    context.Items["CurrentTenant"] = tenant;
                }
                else
                {
                    _logger.LogDebug("未识别到租户信息");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "处理租户信息时发生错误");
            }

            // 继续处理请求
            await _next(context);
        }
    }
}