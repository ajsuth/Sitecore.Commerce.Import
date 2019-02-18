﻿using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;

namespace Feature.Catalog.Engine
{
    public class ImportSellableItemsPolicy : Policy
    {
        public int ItemsPerBatch { get; set; } = 1000;
        public int SleepBetweenBatches { get; set; } = 30000;
        public string FileFolderPath { get; set; } = @"data\Import";
        public string FileArchiveFolderPath { get; set; } = @"data\Import\Archive";
        public string FilePrefix { get; set; } = "ProductImport";
        public string FileExtention { get; set; } = "CSV";
        public char FileSeparator { get; set; } = ',';
    }
}
