namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Converters
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Process;
    using EnsureThat;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using System;

    public static class OptimalProductConverter
    {
        public static OptimalProductResponse ToEntity(this OptimalProduct entityObject)
        {
            EnsureArg.IsNotNull(entityObject, nameof(entityObject));

            var optimalProductResponse = new OptimalProductResponse
            {
                CdmSite = entityObject.CdmSite,
                NotPurchased = string.IsNullOrEmpty(entityObject.NotPurchased) ? 0 : Convert.ToInt32(entityObject.NotPurchased),
                TotalCategories = string.IsNullOrEmpty(entityObject.TotalCategories) ? 0 : Convert.ToInt32(entityObject.TotalCategories),
                GraphNodeSiteKey = entityObject.GraphNodeSiteKey,
            };

            return optimalProductResponse;
        }

        public static IEnumerable<OptimalProductResponse> ToEntityList(this IEnumerable<OptimalProduct> entitiyObjects)
        {
            return entitiyObjects?.Select(optimalProductResponse => optimalProductResponse.ToEntity()).ToList();
        }
    }
}
