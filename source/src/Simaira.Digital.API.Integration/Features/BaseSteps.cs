using Simaira.Digital.API.Integration.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Simaira.Digital.API.Integration.Features
{
    public class BaseSteps : Steps
    {
        protected const string ServiceAreasKey = "serviceAreasKey";

        protected readonly ScenarioContext _scenarioContext;
        protected readonly APIClientFactory _apiClientFactory;
        protected readonly Endpoints _endpoints;
        protected readonly List<string> _emails;

        public BaseSteps(APIClientFactory customerPortalClientFactory, ScenarioContext scenarioContext, Endpoints endpoints)
        {
            _apiClientFactory = customerPortalClientFactory;
            _endpoints = endpoints;
            _scenarioContext = scenarioContext;
            _emails = new List<string>();
        }


        protected void AddToScenarioContext<T>(string key, T value)
        {
            if (_scenarioContext.ContainsKey(key))
            {
                _scenarioContext[key] = value;
            }
            else
            {
                _scenarioContext.Add(key, value);
            }
        }

        protected object GetFromScenarioContext(string key)
        {
            if (_scenarioContext.ContainsKey(key))
            {
                return _scenarioContext[key];
            }

            return null;
        }
    }
}
