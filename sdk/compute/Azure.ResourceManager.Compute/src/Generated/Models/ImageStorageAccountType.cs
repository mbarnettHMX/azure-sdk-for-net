// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the storage account type to be used to store the image. This property is not updatable. </summary>
    public readonly partial struct ImageStorageAccountType : IEquatable<ImageStorageAccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImageStorageAccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImageStorageAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardLrsValue = "Standard_LRS";
        private const string StandardZrsValue = "Standard_ZRS";
        private const string PremiumLrsValue = "Premium_LRS";
        private const string StandardSsdLrsValue = "StandardSSD_LRS";

        /// <summary> Standard_LRS. </summary>
        public static ImageStorageAccountType StandardLrs { get; } = new ImageStorageAccountType(StandardLrsValue);
        /// <summary> Standard_ZRS. </summary>
        public static ImageStorageAccountType StandardZrs { get; } = new ImageStorageAccountType(StandardZrsValue);
        /// <summary> Premium_LRS. </summary>
        public static ImageStorageAccountType PremiumLrs { get; } = new ImageStorageAccountType(PremiumLrsValue);
        /// <summary> StandardSSD_LRS. </summary>
        public static ImageStorageAccountType StandardSsdLrs { get; } = new ImageStorageAccountType(StandardSsdLrsValue);
        /// <summary> Determines if two <see cref="ImageStorageAccountType"/> values are the same. </summary>
        public static bool operator ==(ImageStorageAccountType left, ImageStorageAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImageStorageAccountType"/> values are not the same. </summary>
        public static bool operator !=(ImageStorageAccountType left, ImageStorageAccountType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImageStorageAccountType"/>. </summary>
        public static implicit operator ImageStorageAccountType(string value) => new ImageStorageAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImageStorageAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImageStorageAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
