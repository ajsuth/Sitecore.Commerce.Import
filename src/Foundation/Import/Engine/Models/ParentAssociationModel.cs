﻿using Sitecore.Commerce.Plugin.Catalog;

namespace Foundation.Import.Engine
{
    public class ParentAssociationModel
    {
        public string ItemId { get; set; }
        public string ParentId { get; set; }

        public ParentAssociationModel() { }

        public ParentAssociationModel(string itemId, string parentId)
        {
            ItemId = itemId;
            ParentId = parentId;
        }
    }
}
