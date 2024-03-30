using Microsoft.AspNetCore.Builder;
using cmsKit;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<cmsKitWebTestModule>();

public partial class Program
{
}
