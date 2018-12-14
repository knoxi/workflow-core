﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowCore.Models.LifeCycleEvents
{
    public abstract class LifeCycleEvent
    {
        public DateTime EventTimeUtc { get; set; }

        public string WorkflowInsanceId { get; set; }

        public string WorkflowDefinitionId { get; set; }

        public int Version { get; set; }

        public string Reference { get; set; }
    }
}
