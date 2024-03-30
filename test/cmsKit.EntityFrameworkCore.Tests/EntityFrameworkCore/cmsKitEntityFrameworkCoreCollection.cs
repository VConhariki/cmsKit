using Xunit;

namespace cmsKit.EntityFrameworkCore;

[CollectionDefinition(cmsKitTestConsts.CollectionDefinitionName)]
public class cmsKitEntityFrameworkCoreCollection : ICollectionFixture<cmsKitEntityFrameworkCoreFixture>
{

}
