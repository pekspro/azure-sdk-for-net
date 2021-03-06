// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics
{
    /// <summary> The TasksStateTasksDetails. </summary>
    internal partial class TasksStateTasksDetailsInternal : TaskState
    {
        /// <summary> Initializes a new instance of TasksStateTasksDetailsInternal. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="status"> . </param>
        internal TasksStateTasksDetailsInternal(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of TasksStateTasksDetailsInternal. </summary>
        /// <param name="lastUpdateDateTime"> . </param>
        /// <param name="name"> . </param>
        /// <param name="status"> . </param>
        internal TasksStateTasksDetailsInternal(DateTimeOffset lastUpdateDateTime, string name, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, name, status)
        {
        }
    }
}
