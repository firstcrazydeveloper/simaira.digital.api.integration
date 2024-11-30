using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simaira.Digital.API.Integration.Common
{
    using System.Threading.Tasks;

    public interface IBaseTokenHandler
    {
        Task<AccessToken> GetAccessTokenAsync(
            string applicationClientId,
            string clientSecret,
            string applicationTenantId,
            string authScope);

    }
}
