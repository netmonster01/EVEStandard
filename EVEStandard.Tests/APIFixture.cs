using EVEStandard.API;
using EVEStandard.Enumerations;
using EVEStandard.Models.API;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EVEStandard.Tests
{
    public class APIFixture : IDisposable
    {
        public APIFixture()
        {
            APIBase.ESI_BASE = "http://104.236.92.191:8080";
            EVEStandard = new EVEStandardAPI("EVEStandard Unit Tests", Enumerations.DataSource.Tranquility, TimeSpan.FromSeconds(30), "Testing", "CLIENTID", "NOSECRET");

            AuthDTO = new AuthDTO()
            {
                AccessToken = new Models.SSO.AccessTokenDetails()
                {
                    AccessToken = "Fake",
                    TokenType = "Fake",
                    ExpiresIn = 3600,
                    RefreshToken = "Fake"
                },
                Character = new Models.SSO.CharacterDetails()
                {
                    CharacterID = 1,
                    CharacterName = "Fake",
                    ExpiresOn = DateTime.MaxValue,
                    Scopes = Scopes.ESI_ASSETS_READ_ASSETS_1,
                    TokenType = "Fake",
                    CharacterOwnerHash = "Fake"
                }
            };
        }

        public void Dispose()
        {
            
        }

        public EVEStandardAPI EVEStandard { get; private set; }
        public AuthDTO AuthDTO { get; private set; }
    }

    [CollectionDefinition("API collection")]
    public class APICollection : ICollectionFixture<APIFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
