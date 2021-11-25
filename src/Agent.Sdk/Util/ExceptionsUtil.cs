﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.Services.Agent;

namespace Agent.Sdk.Util
{
    public class ExceptionsUtil
    {
        public static void HandleAggregateException(AggregateException e, ITraceWriter trace)
        {
            trace.Info("One or several exceptions have been occurred.");

            foreach (var ex in ((AggregateException)e).Flatten().InnerExceptions)
            {
                trace.Info(ex.ToString());
            }
        }
    }
}