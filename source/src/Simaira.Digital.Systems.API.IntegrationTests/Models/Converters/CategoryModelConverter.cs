namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Converters
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Process;
    using EnsureThat;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using System;

    public static class CategoryModelConverter
    {
        public static CategoryModelResponse ToEntity(this CategoryModel entityObject)
        {
            EnsureArg.IsNotNull(entityObject, nameof(entityObject));

            var optimalProductResponse = new CategoryModelResponse
            {
                CdmSite = entityObject.CdmSite,
                BrandStandardCategory = entityObject.BrandStandardCategory,
                GraphNodeSiteKey = entityObject.GraphNodeSiteKey,
                IsGoodstanding = entityObject.IsGoodstanding,
                SegmentType = entityObject.SegmentType,                
            };

            return optimalProductResponse;
        }

        public static IEnumerable<CategoryModelResponse> ToEntityList(this IEnumerable<CategoryModel> entitiyObjects)
        {
            return entitiyObjects?.Select(optimalProductResponse => optimalProductResponse.ToEntity()).ToList();
        }
    }
}
