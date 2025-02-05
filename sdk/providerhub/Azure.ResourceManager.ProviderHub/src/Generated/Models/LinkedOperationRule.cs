// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The LinkedOperationRule. </summary>
    public partial class LinkedOperationRule
    {
        /// <summary> Initializes a new instance of LinkedOperationRule. </summary>
        /// <param name="linkedOperation"></param>
        /// <param name="linkedAction"></param>
        internal LinkedOperationRule(LinkedOperation linkedOperation, LinkedAction linkedAction)
        {
            LinkedOperation = linkedOperation;
            LinkedAction = linkedAction;
        }

        /// <summary> Gets the linked operation. </summary>
        public LinkedOperation LinkedOperation { get; }
        /// <summary> Gets the linked action. </summary>
        public LinkedAction LinkedAction { get; }
    }
}
