// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Xenko.Core;

namespace Xenko.Core.Packages
{
    /// <summary>
    /// Representation of a dependency in a package manifest.
    /// </summary>
    public class ManifestDependency
    {
        /// <summary>
        /// Name of package dependency.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Version of package dependency.
        /// </summary>
        public PackageVersionRange Version { get; set; }
    }
}
