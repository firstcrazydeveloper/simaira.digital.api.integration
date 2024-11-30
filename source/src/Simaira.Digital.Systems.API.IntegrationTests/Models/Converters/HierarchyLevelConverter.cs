namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Converters
{
    using Ecolab.Simaira.Digital.CustomerPortal.Model.Process;
    using EnsureThat;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using System;

    public static class HierarchyLevelConverter
    {
        public static HierarchyModel ToEntity(this HierarchyLevel entityObject)
        {
            EnsureArg.IsNotNull(entityObject, nameof(entityObject));

            var hierarchyModel = new HierarchyModel
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
            };

            return hierarchyModel;
        }

        public static IEnumerable<HierarchyModel> ToEntityList(this IEnumerable<HierarchyLevel> entitiyObjects)
        {
            return entitiyObjects?.Select(hierarchyModel => hierarchyModel.ToEntity()).ToList();
        }
    }
}
