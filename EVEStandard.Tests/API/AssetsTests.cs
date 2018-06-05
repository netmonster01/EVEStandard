using EVEStandard.Models.API;
using System.Threading.Tasks;
using Xunit;

namespace EVEStandard.Tests.API
{
    [Collection("API collection")]
    public class AssetsTests
    {
        readonly APIFixture fixture;

        public AssetsTests(APIFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public async Task OneAssetReturned()
        {
            var sut = await fixture.EVEStandard.Assets.GetCharacterAssetsV3Async(fixture.AuthDTO);

            Assert.Single(sut.Model);
        }
    }
}
