﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTool.DBAccess.DatabaseTargets
{
    public enum DbTargetMultipleFoundMode
    {
        None, // No records will be updated 
        All // All records will be updated
    }
}
