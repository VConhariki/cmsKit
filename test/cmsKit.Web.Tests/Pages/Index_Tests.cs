using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace cmsKit.Pages;

public class Index_Tests : cmsKitWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
