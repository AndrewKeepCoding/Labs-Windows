// <auto-generated/>
#pragma warning disable
#nullable enable

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#if GENERATED_DEPENDENCY_PROPERTY_PRIVATE_ASSETS_ALL_MODE

namespace CommunityToolkit.WinUI
{
#if GENERATED_DEPENDENCY_PROPERTY_USE_WINDOWS_UI_XAML
    using DependencyObject = global::Windows.UI.Xaml.DependencyObject;
    using DependencyProperty = global::Windows.UI.Xaml.DependencyProperty;
    using PropertyMetadata = global::Windows.UI.Xaml.PropertyMetadata;
#else
    using DependencyObject = global::Microsoft.UI.Xaml.DependencyObject;
    using DependencyProperty = global::Microsoft.UI.Xaml.DependencyProperty;
    using PropertyMetadata = global::Microsoft.UI.Xaml.PropertyMetadata;
#endif

    /// <summary>
    /// An attribute that indicates that a given partial property should generate a backing <see cref="DependencyProperty"/>.
    /// In order to use this attribute, the containing type has to inherit from <see cref="DependencyObject"/>.
    /// <para>
    /// This attribute can be used as follows:
    /// <code>
    /// partial class MyClass : DependencyObject
    /// {
    ///     [GeneratedDependencyProperty]
    ///     public partial string? Name { get; set; }
    /// }
    /// </code>
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// In order to use this attribute on partial properties, the .NET 9 SDK is required, and C# 13 (or 'preview') must be used.
    /// </para>
    /// </remarks>
    [global::System.AttributeUsage(global::System.AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    [global::System.CodeDom.Compiler.GeneratedCode("<GENERATOR_NAME>", "<ASSEMBLY_VERSION>")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.Conditional("GENERATED_DEPENDENCY_PROPERTY_PRIVATE_ASSETS_ALL_PRESERVE_ATTRIBUTES")]
    internal sealed class GeneratedDependencyPropertyAttribute : global::System.Attribute
    {
        /// <summary>
        /// Gets a value indicating the default value to set for the property.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If not set, the default value will be <see langword="null"/>, for all property types. If there is no callback
        /// registered for the generated property, <see cref="PropertyMetadata"/> will not be set at all.
        /// </para>
        /// <para>
        /// To set the default value to <see cref="DependencyProperty.UnsetValue"/>, use <see cref="GeneratedDependencyProperty.UnsetValue"/>.
        /// </para>
        /// </remarks>
        public object? DefaultValue { get; init; } = null;

        /// <summary>
        /// Gets a value indicating whether or not property values should be cached locally, to improve performance.
        /// This allows completely skipping boxing (for value types) and all WinRT marshalling when setting properties.
        /// </summary>
        /// <remarks>
        /// Local caching is disabled by default. It should be disabled in scenarios where the values of the dependency
        /// properties might also be set outside of the partial property implementation, meaning caching would be invalid.
        /// </remarks>
        public bool IsLocalCacheEnabled { get; init; } = false;
    }
}

#endif
