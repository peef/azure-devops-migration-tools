﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTS.DataBulkEditor.Engine.Configuration.Processing
{
    public class WorkItemUpdateAreasAsTagsConfig : ITfsProcessingConfig
    {
        public bool Disabled { get; set; }
        public string AreaIterationPath { get; set; }

        public Type Processor
        {
            get
            {
                return typeof(WorkItemUpdateAreasAsTagsContext);
            }
        }

    }
    }

