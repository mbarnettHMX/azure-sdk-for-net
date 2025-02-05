// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Purview.Workflows
{
    /// <summary> Client options for PurviewWorkflowServiceClient. </summary>
    public partial class PurviewWorkflowServiceClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2022_05_01_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-05-01-preview". </summary>
            V2022_05_01_Preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of PurviewWorkflowServiceClientOptions. </summary>
        public PurviewWorkflowServiceClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_05_01_Preview => "2022-05-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
