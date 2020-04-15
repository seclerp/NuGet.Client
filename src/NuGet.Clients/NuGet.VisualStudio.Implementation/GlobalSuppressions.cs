﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1031:Modify 'InitializeTypes' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.ExtensionManagerShim.InitializeTypes(System.Action{System.String})")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.StartsWith(string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.VisualStudio.ExtensionManagerShim.InitializeTypes(System.Action<string>)' with a call to 'string.StartsWith(string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.ExtensionManagerShim.InitializeTypes(System.Action{System.String})")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'CreateMetadata' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PackageManagementHelpers.CreateMetadata(System.String,NuGet.Packaging.Core.PackageIdentity)~NuGet.VisualStudio.IVsPackageMetadata")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new PackageFolderReader(packageFolder)' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.AddRefreshFilesForReferences(EnvDTE.Project,System.String,System.Collections.Generic.IEnumerable{NuGet.Packaging.Core.PackageIdentity})")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'repositoryPath'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.AddRefreshFilesForReferences(EnvDTE.Project,System.String,System.Collections.Generic.IEnumerable{NuGet.Packaging.Core.PackageIdentity})")]
[assembly: SuppressMessage("Build", "CA1801:Parameter repositoryPath of method CopyNativeBinaries is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.CopyNativeBinaries(NuGet.PackageManagement.VisualStudio.VsMSBuildProjectSystem,System.String,System.String)")]
[assembly: SuppressMessage("Build", "CA1822:Member CopyNativeBinaries does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.CopyNativeBinaries(NuGet.PackageManagement.VisualStudio.VsMSBuildProjectSystem,System.String,System.String)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'PreinstalledPackageInstaller.GetExtensionRepositoryPath(string, object, Action<string>)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.GetExtensionRepositoryPath(System.String,System.Object,System.Action{System.String})~System.String")]
[assembly: SuppressMessage("Build", "CA1822:Member GetExtensionRepositoryPath does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.GetExtensionRepositoryPath(System.String,System.Object,System.Action{System.String})~System.String")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'PreinstalledPackageInstaller.GetRegistryRepositoryPath(string, IEnumerable<IRegistryKey>, Action<string>)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.GetRegistryRepositoryPath(System.String,System.Collections.Generic.IEnumerable{NuGet.VisualStudio.IRegistryKey},System.Action{System.String})~System.String")]
[assembly: SuppressMessage("Build", "CA1822:Member GetRegistryRepositoryPath does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.GetRegistryRepositoryPath(System.String,System.Collections.Generic.IEnumerable{NuGet.VisualStudio.IRegistryKey},System.Action{System.String})~System.String")]
[assembly: SuppressMessage("Build", "CA1801:Parameter packageInstaller of method PerformPackageInstallAsync is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.PerformPackageInstallAsync(NuGet.VisualStudio.IVsPackageInstaller,EnvDTE.Project,NuGet.VisualStudio.PreinstalledPackageConfiguration,System.Boolean,System.Action{System.String},System.Action{System.String})~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'PreinstalledPackageInstaller.PerformPackageInstallAsync(IVsPackageInstaller, Project, PreinstalledPackageConfiguration, bool, Action<string>, Action<string>)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.PerformPackageInstallAsync(NuGet.VisualStudio.IVsPackageInstaller,EnvDTE.Project,NuGet.VisualStudio.PreinstalledPackageConfiguration,System.Boolean,System.Action{System.String},System.Action{System.String})~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1801:Parameter provider of method AddFromExtension is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledRepositoryProvider.AddFromExtension(NuGet.Protocol.Core.Types.ISourceRepositoryProvider,System.String)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'PreinstalledRepositoryProvider.GetExtensionRepositoryPath(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledRepositoryProvider.GetExtensionRepositoryPath(System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'PreinstalledRepositoryProvider.GetRegistryRepositoryPath(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledRepositoryProvider.GetRegistryRepositoryPath(System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'VsFrameworkCompatibility.GetFrameworksSupportingNetStandard(FrameworkName)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsFrameworkCompatibility.GetFrameworksSupportingNetStandard(System.Runtime.Versioning.FrameworkName)~System.Collections.Generic.IEnumerable{System.Runtime.Versioning.FrameworkName}")]
[assembly: SuppressMessage("Build", "CA1806:GetIdentitiesFromDict calls TryParse but does not explicitly check whether the conversion succeeded. Either use the return value in a conditional statement or verify that the call site expects that the out argument will be set to the default value when the conversion fails.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstaller.GetIdentitiesFromDict(System.Collections.Generic.IDictionary{System.String,System.String})~System.Collections.Generic.List{NuGet.Packaging.Core.PackageIdentity}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'VsPackageInstaller.GetSource(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstaller.GetSource(System.String)~NuGet.Protocol.Core.Types.SourceRepository")]
[assembly: SuppressMessage("Build", "CA1822:Member InstallInternalCoreAsync does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstaller.InstallInternalCoreAsync(NuGet.PackageManagement.NuGetPackageManager,NuGet.PackageManagement.GatherCache,NuGet.ProjectManagement.NuGetProject,NuGet.Packaging.Core.PackageIdentity,System.Collections.Generic.IEnumerable{NuGet.Protocol.Core.Types.SourceRepository},NuGet.VisualStudio.VSAPIProjectContext,System.Boolean,System.Boolean,System.Threading.CancellationToken)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1806:InstallPackage calls TryParse but does not explicitly check whether the conversion succeeded. Either use the return value in a conditional statement or verify that the call site expects that the out argument will be set to the default value when the conversion fails.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstaller.InstallPackage(System.String,EnvDTE.Project,System.String,System.String,System.Boolean)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'VsPackageInstallerEvents.VsPackageInstallerEvents(IPackageEventsProvider eventProvider)', validate parameter 'eventProvider' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerEvents.#ctor(NuGet.ProjectManagement.IPackageEventsProvider)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'VsPackageInstallerProjectEvents.VsPackageInstallerProjectEvents(IPackageProjectEventsProvider eventProvider)', validate parameter 'eventProvider' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerProjectEvents.#ctor(NuGet.PackageManagement.IPackageProjectEventsProvider)")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'project'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerServices.GetInstalledPackageReferencesAsync(EnvDTE.Project)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{NuGet.Packaging.PackageReference}}")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'project'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerServices.GetInstalledPackages(EnvDTE.Project)~System.Collections.Generic.IEnumerable{NuGet.VisualStudio.IVsPackageMetadata}")]
[assembly: SuppressMessage("Build", "CA2208:Method IsPackageInstalled passes 'versionString' as the paramName argument to a ArgumentException constructor. Replace this argument with one of the method's parameter names. Note that the provided parameter name should have the exact casing as declared on the method.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerServices.IsPackageInstalled(EnvDTE.Project,System.String,NuGet.SemanticVersion)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool VsPackageInstallerServices.IsPackageInstalled(Project project, string packageId, SemanticVersion version)', validate parameter 'version' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerServices.IsPackageInstalled(EnvDTE.Project,System.String,NuGet.SemanticVersion)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'project'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerServices.IsPackageInstalled(EnvDTE.Project,System.String,NuGet.Versioning.NuGetVersion)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'versionString'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerServices.IsPackageInstalledEx(EnvDTE.Project,System.String,System.String)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'RestorePackages' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageRestorer.RestorePackages(EnvDTE.Project)")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'project'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageUninstaller.UninstallPackage(EnvDTE.Project,System.String,System.Boolean)")]
[assembly: SuppressMessage("Build", "CA1801:Parameter token of method GetPathContextFromAssetsFileAsync is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPathContextProvider.GetPathContextFromAssetsFileAsync(NuGet.ProjectManagement.Projects.BuildIntegratedNuGetProject,System.Threading.CancellationToken)~System.Threading.Tasks.Task{NuGet.VisualStudio.IVsPathContext}")]
[assembly: SuppressMessage("Build", "CA1822:Member GetProjectsInSolutionAsync does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPathContextProvider.GetProjectsInSolutionAsync(EnvDTE.DTE)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{EnvDTE.Project}}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'VsProjectJsonToPackageReferenceMigrator.MigrateProjectJsonToPackageReferenceAsync(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsProjectJsonToPackageReferenceMigrator.MigrateProjectJsonToPackageReferenceAsync(System.String)~System.Threading.Tasks.Task{System.Object}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'VsProjectJsonToPackageReferenceMigrator.MigrateProjectToPackageRefAsync(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsProjectJsonToPackageReferenceMigrator.MigrateProjectToPackageRefAsync(System.String)~System.Threading.Tasks.Task{System.Object}")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'MigrateProjectToPackageRefAsync' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsProjectJsonToPackageReferenceMigrator.MigrateProjectToPackageRefAsync(System.String)~System.Threading.Tasks.Task{System.Object}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'DateTime.ToString(string)' could vary based on the current user's locale settings. Replace this call in 'VsTemplateWizard.AddTemplateParameters(Dictionary<string, string>)' with a call to 'DateTime.ToString(string, IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsTemplateWizard.AddTemplateParameters(System.Collections.Generic.Dictionary{System.String,System.String})")]
[assembly: SuppressMessage("Build", "CA1806:GetConfigurationsFromXmlDocument calls TryParse but does not explicitly check whether the conversion succeeded. Either use the return value in a conditional statement or verify that the call site expects that the out argument will be set to the default value when the conversion fails.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsTemplateWizard.GetConfigurationsFromXmlDocument(System.Xml.Linq.XDocument,System.String,System.Object,System.Collections.Generic.IEnumerable{NuGet.VisualStudio.IRegistryKey})~System.Collections.Generic.IEnumerable{NuGet.VisualStudio.PreinstalledPackageConfiguration}")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<PreinstalledPackageInfo>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsTemplateWizard.GetConfigurationsFromXmlDocument(System.Xml.Linq.XDocument,System.String,System.Object,System.Collections.Generic.IEnumerable{NuGet.VisualStudio.IRegistryKey})~System.Collections.Generic.IEnumerable{NuGet.VisualStudio.PreinstalledPackageConfiguration}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'VsTemplateWizard.GetRepositoryType(XElement)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsTemplateWizard.GetRepositoryType(System.Xml.Linq.XElement)~NuGet.VisualStudio.VsTemplateWizard.RepositoryType")]
[assembly: SuppressMessage("Build", "CA1822:Member RunDesignTimeBuild does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsTemplateWizard.RunDesignTimeBuild(EnvDTE.Project)")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'XmlReader.Create(input, settings)' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.XmlUtility.LoadSafe(System.IO.Stream)~System.Xml.Linq.XDocument")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'XmlReader.Create(input, settings)' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.XmlUtility.LoadSafe(System.IO.Stream,System.Boolean)~System.Xml.Linq.XDocument")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'XmlReader.Create(input, settings)' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.XmlUtility.LoadSafe(System.IO.Stream,System.Xml.Linq.LoadOptions)~System.Xml.Linq.XDocument")]
[assembly: SuppressMessage("Build", "CA1822:Member ErrorHandler does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.VisualStudio.VsPackageInstaller.ErrorHandler")]
