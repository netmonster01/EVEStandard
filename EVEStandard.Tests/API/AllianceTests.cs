using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EVEStandard.Tests.API
{
    [Collection("API collection")]
    public class AllianceTests
    {
        readonly APIFixture fixture;

        public AllianceTests(APIFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public async Task TwoAlliancesReturned()
        {
            var sut = await fixture.EVEStandard.Alliances.ListAllAlliancesV1Async();

            Assert.NotEmpty(sut.Model);
        }
    }
}
