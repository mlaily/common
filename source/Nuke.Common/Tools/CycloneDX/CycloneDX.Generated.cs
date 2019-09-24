// Generated from https://github.com/mlaily/common/blob/master/build/specifications/CycloneDX.json
// Generated with Nuke.CodeGeneration version LOCAL (Windows,.NETStandard,Version=v2.0)

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.CycloneDX
{
    /// <summary>
    ///   <p>CycloneDX is a lightweight software bill-of-material (SBOM) specification designed for use in application security contexts and supply chain component analysis.</p>
    ///   <p>For more details, visit the <a href="https://cyclonedx.org/">official website</a>.</p>
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class CycloneDXTasks
    {
        /// <summary>
        ///   Path to the CycloneDX executable.
        /// </summary>
        public static string CycloneDXPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("CYCLONEDX_EXE") ??
            ToolPathResolver.GetPackageExecutable("CycloneDX", "CycloneDX.dll");
        public static Action<OutputType, string> CycloneDXLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   <p>CycloneDX is a lightweight software bill-of-material (SBOM) specification designed for use in application security contexts and supply chain component analysis.</p>
        ///   <p>For more details, visit the <a href="https://cyclonedx.org/">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> CycloneDX(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            var process = ProcessTasks.StartProcess(CycloneDXPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, CycloneDXLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>CycloneDX is a lightweight software bill-of-material (SBOM) specification designed for use in application security contexts and supply chain component analysis.</p>
        ///   <p>For more details, visit the <a href="https://cyclonedx.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;path&gt;</c> via <see cref="CycloneDXSettings.Path"/></li>
        ///     <li><c>--noSerialNumber</c> via <see cref="CycloneDXSettings.NoSerialNumber"/></li>
        ///     <li><c>--out</c> via <see cref="CycloneDXSettings.OutputDirectory"/></li>
        ///     <li><c>--recursive</c> via <see cref="CycloneDXSettings.Recursive"/></li>
        ///     <li><c>--url</c> via <see cref="CycloneDXSettings.AlternativeNuGetUrl"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> CycloneDX(CycloneDXSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new CycloneDXSettings();
            var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>CycloneDX is a lightweight software bill-of-material (SBOM) specification designed for use in application security contexts and supply chain component analysis.</p>
        ///   <p>For more details, visit the <a href="https://cyclonedx.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;path&gt;</c> via <see cref="CycloneDXSettings.Path"/></li>
        ///     <li><c>--noSerialNumber</c> via <see cref="CycloneDXSettings.NoSerialNumber"/></li>
        ///     <li><c>--out</c> via <see cref="CycloneDXSettings.OutputDirectory"/></li>
        ///     <li><c>--recursive</c> via <see cref="CycloneDXSettings.Recursive"/></li>
        ///     <li><c>--url</c> via <see cref="CycloneDXSettings.AlternativeNuGetUrl"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> CycloneDX(Configure<CycloneDXSettings> configurator)
        {
            return CycloneDX(configurator(new CycloneDXSettings()));
        }
        /// <summary>
        ///   <p>CycloneDX is a lightweight software bill-of-material (SBOM) specification designed for use in application security contexts and supply chain component analysis.</p>
        ///   <p>For more details, visit the <a href="https://cyclonedx.org/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>&lt;path&gt;</c> via <see cref="CycloneDXSettings.Path"/></li>
        ///     <li><c>--noSerialNumber</c> via <see cref="CycloneDXSettings.NoSerialNumber"/></li>
        ///     <li><c>--out</c> via <see cref="CycloneDXSettings.OutputDirectory"/></li>
        ///     <li><c>--recursive</c> via <see cref="CycloneDXSettings.Recursive"/></li>
        ///     <li><c>--url</c> via <see cref="CycloneDXSettings.AlternativeNuGetUrl"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(CycloneDXSettings Settings, IReadOnlyCollection<Output> Output)> CycloneDX(CombinatorialConfigure<CycloneDXSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(CycloneDX, CycloneDXLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region CycloneDXSettings
    /// <summary>
    ///   Used within <see cref="CycloneDXTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class CycloneDXSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the CycloneDX executable.
        /// </summary>
        public override string ToolPath => base.ToolPath ?? CycloneDXTasks.CycloneDXPath;
        public override Action<OutputType, string> CustomLogger => CycloneDXTasks.CycloneDXLogger;
        /// <summary>
        ///   The path to a .sln, .csproj, .vbproj, or packages.config file or the path to a directory which will be recursively analyzed for packages.config files.
        /// </summary>
        public virtual string Path { get; internal set; }
        /// <summary>
        ///   The directory to write bom.xml
        /// </summary>
        public virtual string OutputDirectory { get; internal set; }
        /// <summary>
        ///   Alternative NuGet repository URL to v3-flatcontainer API (a trailing slash is required).
        /// </summary>
        public virtual string AlternativeNuGetUrl { get; internal set; }
        /// <summary>
        ///   To be used with a single project file, it will recursively scan project references of the supplied .csproj.
        /// </summary>
        public virtual bool? Recursive { get; internal set; }
        /// <summary>
        ///   Optionally omit the serial number from the resulting BOM.
        /// </summary>
        public virtual bool? NoSerialNumber { get; internal set; }
        protected override Arguments ConfigureArguments(Arguments arguments)
        {
            arguments
              .Add("{value}", Path)
              .Add("--out {value}", OutputDirectory)
              .Add("--url {value}", AlternativeNuGetUrl)
              .Add("--recursive", Recursive)
              .Add("--noSerialNumber", NoSerialNumber);
            return base.ConfigureArguments(arguments);
        }
    }
    #endregion
    #region CycloneDXSettingsExtensions
    /// <summary>
    ///   Used within <see cref="CycloneDXTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class CycloneDXSettingsExtensions
    {
        #region Path
        /// <summary>
        ///   <p><em>Sets <see cref="CycloneDXSettings.Path"/></em></p>
        ///   <p>The path to a .sln, .csproj, .vbproj, or packages.config file or the path to a directory which will be recursively analyzed for packages.config files.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings SetPath(this CycloneDXSettings toolSettings, string path)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = path;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="CycloneDXSettings.Path"/></em></p>
        ///   <p>The path to a .sln, .csproj, .vbproj, or packages.config file or the path to a directory which will be recursively analyzed for packages.config files.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings ResetPath(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Path = null;
            return toolSettings;
        }
        #endregion
        #region OutputDirectory
        /// <summary>
        ///   <p><em>Sets <see cref="CycloneDXSettings.OutputDirectory"/></em></p>
        ///   <p>The directory to write bom.xml</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings SetOutputDirectory(this CycloneDXSettings toolSettings, string outputDirectory)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectory = outputDirectory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="CycloneDXSettings.OutputDirectory"/></em></p>
        ///   <p>The directory to write bom.xml</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings ResetOutputDirectory(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OutputDirectory = null;
            return toolSettings;
        }
        #endregion
        #region AlternativeNuGetUrl
        /// <summary>
        ///   <p><em>Sets <see cref="CycloneDXSettings.AlternativeNuGetUrl"/></em></p>
        ///   <p>Alternative NuGet repository URL to v3-flatcontainer API (a trailing slash is required).</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings SetAlternativeNuGetUrl(this CycloneDXSettings toolSettings, string alternativeNuGetUrl)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlternativeNuGetUrl = alternativeNuGetUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="CycloneDXSettings.AlternativeNuGetUrl"/></em></p>
        ///   <p>Alternative NuGet repository URL to v3-flatcontainer API (a trailing slash is required).</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings ResetAlternativeNuGetUrl(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AlternativeNuGetUrl = null;
            return toolSettings;
        }
        #endregion
        #region Recursive
        /// <summary>
        ///   <p><em>Sets <see cref="CycloneDXSettings.Recursive"/></em></p>
        ///   <p>To be used with a single project file, it will recursively scan project references of the supplied .csproj.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings SetRecursive(this CycloneDXSettings toolSettings, bool? recursive)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recursive = recursive;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="CycloneDXSettings.Recursive"/></em></p>
        ///   <p>To be used with a single project file, it will recursively scan project references of the supplied .csproj.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings ResetRecursive(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recursive = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="CycloneDXSettings.Recursive"/></em></p>
        ///   <p>To be used with a single project file, it will recursively scan project references of the supplied .csproj.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings EnableRecursive(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recursive = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="CycloneDXSettings.Recursive"/></em></p>
        ///   <p>To be used with a single project file, it will recursively scan project references of the supplied .csproj.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings DisableRecursive(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recursive = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="CycloneDXSettings.Recursive"/></em></p>
        ///   <p>To be used with a single project file, it will recursively scan project references of the supplied .csproj.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings ToggleRecursive(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Recursive = !toolSettings.Recursive;
            return toolSettings;
        }
        #endregion
        #region NoSerialNumber
        /// <summary>
        ///   <p><em>Sets <see cref="CycloneDXSettings.NoSerialNumber"/></em></p>
        ///   <p>Optionally omit the serial number from the resulting BOM.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings SetNoSerialNumber(this CycloneDXSettings toolSettings, bool? noSerialNumber)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSerialNumber = noSerialNumber;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="CycloneDXSettings.NoSerialNumber"/></em></p>
        ///   <p>Optionally omit the serial number from the resulting BOM.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings ResetNoSerialNumber(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSerialNumber = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="CycloneDXSettings.NoSerialNumber"/></em></p>
        ///   <p>Optionally omit the serial number from the resulting BOM.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings EnableNoSerialNumber(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSerialNumber = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="CycloneDXSettings.NoSerialNumber"/></em></p>
        ///   <p>Optionally omit the serial number from the resulting BOM.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings DisableNoSerialNumber(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSerialNumber = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="CycloneDXSettings.NoSerialNumber"/></em></p>
        ///   <p>Optionally omit the serial number from the resulting BOM.</p>
        /// </summary>
        [Pure]
        public static CycloneDXSettings ToggleNoSerialNumber(this CycloneDXSettings toolSettings)
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.NoSerialNumber = !toolSettings.NoSerialNumber;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
