namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class AccessToken
    {
        // I usually let my token "expire" 5 minutes before it's actual expiration
        // to avoid using expired tokens and getting 401.
        private static readonly TimeSpan Threshold = new TimeSpan(0, 5, 0);

        public AccessToken(string token, DateTime expireOn) : this(token, null, expireOn)
        {

        }

        public AccessToken(
            string token,
            string? refreshToken,
            DateTime expireOn)
        {
            Token = token;
            RefreshToken = refreshToken;
            //ExpiresInSeconds = expiresInSeconds;
            Expires = expireOn;
        }

        public string Token { get; }

        public string? RefreshToken { get; }

        public DateTime Expires { get; }

        public bool Expired => (Expires - DateTime.UtcNow).TotalSeconds <= Threshold.TotalSeconds;
    }
}
