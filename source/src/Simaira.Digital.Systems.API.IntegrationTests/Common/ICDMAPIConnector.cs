namespace Simaira.Digital.Systems.IntegrationTests.Common
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICDMAPIConnector
    {
        Task<T> CDMGetAsync<T>(string url);
    }
}
