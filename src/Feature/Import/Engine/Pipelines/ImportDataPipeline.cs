﻿using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;

namespace Feature.Import.Engine
{
    public class ImportDataPipeline : CommercePipeline<string, string>, IImportDataPipeline
    {
        public ImportDataPipeline(IPipelineConfiguration<IImportDataPipeline> configuration, ILoggerFactory loggerFactory) : base(configuration, loggerFactory)
        {
        }
    }
}