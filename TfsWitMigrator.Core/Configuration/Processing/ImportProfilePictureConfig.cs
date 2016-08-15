﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTS.DataBulkEditor.Engine.Configuration.Processing
{
    public class ImportProfilePictureConfig : ITfsProcessingConfig
    {
        public bool Disabled { get; set; }

        public Type Processor
        {
            get
            {
                return typeof(ImportProfilePictureContext);
            }
        }

    }
    }

