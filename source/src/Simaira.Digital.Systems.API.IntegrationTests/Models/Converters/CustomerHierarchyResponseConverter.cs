namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Converters
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Dtos;
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Process;
    using EnsureThat;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using System;


    public static class CustomerHierarchyResponseConverter
    {
        public static CustomerHierarchyResponseModel ToEntity(this CustomerHierarchyResponse entityObject)
        {
            EnsureArg.IsNotNull(entityObject, nameof(entityObject));

            var customerHierarchyResponseModel = new CustomerHierarchyResponseModel
            {
                ErrorMessage = entityObject.ErrorMessage,
                Hierarchy = entityObject.Hierarchy.ToEntityList(),
                HttpStatusCode = entityObject.HttpStatusCode,
                Id = entityObject.Id,
                Status = entityObject.Status,
                StrCode = entityObject.StrCode,
            };

            return customerHierarchyResponseModel;
        }

        public static IEnumerable<CustomerHierarchyResponseModel> ToEntityList(this IEnumerable<CustomerHierarchyResponse> entitiyObjects)
        {
            return entitiyObjects?.Select(optimalProductResponse => optimalProductResponse.ToEntity()).ToList();
        }


        public static CustomerHierarchyModel ToEntity(this CustomerHierarchy entityObject)
        {
            EnsureArg.IsNotNull(entityObject, nameof(entityObject));

            var customerHierarchyModel = new CustomerHierarchyModel
            {
                CdmSite = entityObject.CdmSite,
                GraphNodeSiteKey = entityObject.GraphNodeSiteKey,
                HierarchyLevel1 = entityObject.HierarchyLevel1,
                HierarchyLevel2 = entityObject.HierarchyLevel2,
                HierarchyLevel3 = entityObject.HierarchyLevel3,
                HierarchyLevel4 = entityObject.HierarchyLevel4,
                HierarchyLevel5 = entityObject.HierarchyLevel5,
                HierarchyLevel6 = entityObject.HierarchyLevel6,
                HierarchyLevel7 = entityObject.HierarchyLevel7,
                HierarchyLevel8 = entityObject.HierarchyLevel8,
                HierarchyLevel9 = entityObject.HierarchyLevel9,
                HierarchyLevel10 = entityObject.HierarchyLevel10,
                AccountNumber = entityObject.AccountNumber,
            };

            return customerHierarchyModel;
        }

        public static IEnumerable<CustomerHierarchyModel> ToEntityList(this IEnumerable<CustomerHierarchy> entitiyObjects)
        {
            return entitiyObjects?.Select(customerHierarchyModel => customerHierarchyModel.ToEntity()).ToList();
        }


    }
}
