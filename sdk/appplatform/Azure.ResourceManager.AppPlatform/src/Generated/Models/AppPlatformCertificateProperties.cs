// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary>
    /// Certificate resource payload.
    /// Please note <see cref="AppPlatformCertificateProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AppPlatformContentCertificateProperties"/> and <see cref="AppPlatformKeyVaultCertificateProperties"/>.
    /// </summary>
    public abstract partial class AppPlatformCertificateProperties
    {
        /// <summary> Initializes a new instance of AppPlatformCertificateProperties. </summary>
        protected AppPlatformCertificateProperties()
        {
            DnsNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppPlatformCertificateProperties. </summary>
        /// <param name="certificatePropertiesType"> The type of the certificate source. </param>
        /// <param name="thumbprint"> The thumbprint of certificate. </param>
        /// <param name="issuer"> The issuer of certificate. </param>
        /// <param name="issuedOn"> The issue date of certificate. </param>
        /// <param name="expireOn"> The expiration date of certificate. </param>
        /// <param name="activateOn"> The activate date of certificate. </param>
        /// <param name="subjectName"> The subject name of certificate. </param>
        /// <param name="dnsNames"> The domain list of certificate. </param>
        /// <param name="provisioningState"> Provisioning state of the Certificate. </param>
        internal AppPlatformCertificateProperties(string certificatePropertiesType, string thumbprint, string issuer, DateTimeOffset? issuedOn, DateTimeOffset? expireOn, DateTimeOffset? activateOn, string subjectName, IReadOnlyList<string> dnsNames, AppPlatformCertificateProvisioningState? provisioningState)
        {
            CertificatePropertiesType = certificatePropertiesType;
            Thumbprint = thumbprint;
            Issuer = issuer;
            IssuedOn = issuedOn;
            ExpireOn = expireOn;
            ActivateOn = activateOn;
            SubjectName = subjectName;
            DnsNames = dnsNames;
            ProvisioningState = provisioningState;
        }

        /// <summary> The type of the certificate source. </summary>
        internal string CertificatePropertiesType { get; set; }
        /// <summary> The thumbprint of certificate. </summary>
        public string Thumbprint { get; }
        /// <summary> The issuer of certificate. </summary>
        public string Issuer { get; }
        /// <summary> The issue date of certificate. </summary>
        public DateTimeOffset? IssuedOn { get; }
        /// <summary> The expiration date of certificate. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> The activate date of certificate. </summary>
        public DateTimeOffset? ActivateOn { get; }
        /// <summary> The subject name of certificate. </summary>
        public string SubjectName { get; }
        /// <summary> The domain list of certificate. </summary>
        public IReadOnlyList<string> DnsNames { get; }
        /// <summary> Provisioning state of the Certificate. </summary>
        public AppPlatformCertificateProvisioningState? ProvisioningState { get; }
    }
}
