// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.VisualStudio.Azure
{
    /// <summary>
    /// An interface that an implementation of <see cref="T:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy"/> for a project
    /// can optionally implement to receive notifications from an Azure project that adds it as a role.
    /// </summary>
    /// <remarks>
    /// The purpose is to allow other project systems to know when a project of theirs becomes a web role or a worker role project,
    /// so that they can perform any necessary modifications to the service definition file that are specific to that project system.
    /// </remarks>
    [ComImport]
    [ComVisible(true)]
    [Guid("14A1D483-5615-4D1B-AB1A-BF404FDE31F7")]
    internal interface IAzureRoleProject
    {
        /// <summary>
        /// Called on an instance of <see cref="T:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy"/> for the project when
        /// that project is added as a role to an Azure project. 
        /// </summary>
        /// <param name="azureProjectHierarchy">
        /// The project hierarchy corresponding to the Azure project to which this project has been added as a role.
        /// </param>
        /// <param name="roleType">
        /// The role of this project in the Azure project:
        /// <list type="table">
        ///     <item>
        ///         <term><c>"Web"</c></term>
        ///         <description>This project is a web role project.</description>
        ///     </item>
        ///     <item>
        ///         <term><c>"Worker"</c></term>
        ///         <description>This project is a worker role project.</description>
        ///     </item>
        ///     <item>
        ///         <term>Empty string</term>
        ///         <description>This project doesn't have any definitive role.</description>
        ///     </item>
        /// </list>
        /// </param>
        /// <remarks>
        /// <para>
        /// <paramref name="azureProjectHierarchy"/> is guaranteed to implement <see cref="T:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy"/>.
        /// </para>
        /// <para>
        /// For the sake of forward compatibility, all implementers should be prepared to receive and gracefully handle any string value
        /// in <paramref name="roleType"/>, not just the ones listed.
        /// </para>
        /// </remarks>
        [DispId(0x60020000)]
        void AddedAsRole(object azureProjectHierarchy, string roleType);
    }
}

