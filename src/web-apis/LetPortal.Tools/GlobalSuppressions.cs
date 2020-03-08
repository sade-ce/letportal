﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member GetAvailableCommands does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:LET.Tools.Installation.Program.GetAvailableCommands~System.Collections.Generic.IEnumerable{LetPortal.Tools.Features.IFeatureCommand}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'Program.GetDefaultConnectionString(ConnectionType, string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:LET.Tools.Installation.Program.GetDefaultConnectionString(LetPortal.Core.Persistences.ConnectionType,System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member GetDefaultConnectionString does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:LET.Tools.Installation.Program.GetDefaultConnectionString(LetPortal.Core.Persistences.ConnectionType,System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member GetToolsOptions does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:LET.Tools.Installation.Program.GetToolsOptions(System.String)~LetPortal.Tools.ToolsOptions")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1031:Modify 'Main' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:LET.Tools.Installation.Program.Main(System.String[])~System.Threading.Tasks.Task{System.Int32}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1303:Method 'Task<int> Program.Main(string[] args)' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"--------------------++++LETPORTAL CLI++++-----------------------\".", Justification = "<Pending>", Scope = "member", Target = "~M:LET.Tools.Installation.Program.Main(System.String[])~System.Threading.Tasks.Task{System.Int32}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1304:The behavior of 'string.ToLower()' could vary based on the current user's locale settings. Replace this call in 'Program.OnExecuteAsync()' with a call to 'string.ToLower(CultureInfo)'.", Justification = "<Pending>", Scope = "member", Target = "~M:LET.Tools.Installation.Program.OnExecuteAsync~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1303:Method 'Task Program.OnExecuteAsync()' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"Oops! We don't find any matching command to execute. If you don't know how to run, please type '--help'\".", Justification = "<Pending>", Scope = "member", Target = "~M:LET.Tools.Installation.Program.OnExecuteAsync~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'Downgrade.DowngradingVersion(IEnumerable<IVersion>, ToolsContext)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Downgrade.DowngradingVersion(System.Collections.Generic.IEnumerable{LetPortal.Core.Versions.IVersion},LetPortal.Tools.ToolsContext)~System.Collections.Generic.List{LetPortal.Core.Versions.Version}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1303:Method 'Task Downgrade.RunAsync(ToolsContext context)' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"Oops we can't find any installation in the database, please use 'install' command before downgrading.\".", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Downgrade.RunAsync(LetPortal.Tools.ToolsContext)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'Downgrade.RunAsync(ToolsContext)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Downgrade.RunAsync(LetPortal.Tools.ToolsContext)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1303:Method 'Task Info.RunAsync(ToolsContext context)' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"Oops we don't find any installation in the database.\".", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Info.RunAsync(LetPortal.Tools.ToolsContext)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'Install.InstallingVersion(IEnumerable<IVersion>, ToolsContext)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Install.InstallingVersion(System.Collections.Generic.IEnumerable{LetPortal.Core.Versions.IVersion},LetPortal.Tools.ToolsContext)~System.Collections.Generic.List{LetPortal.Core.Versions.Version}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1303:Method 'List<Version> Install.InstallingVersion(IEnumerable<IVersion> versions, ToolsContext toolsContext)' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"----------------------------------------------------------------\".", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Install.InstallingVersion(System.Collections.Generic.IEnumerable{LetPortal.Core.Versions.IVersion},LetPortal.Tools.ToolsContext)~System.Collections.Generic.List{LetPortal.Core.Versions.Version}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1303:Method 'Task Install.RunAsync(ToolsContext context)' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"-----------------------INSTALL PROGRESS-------------------------\".", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Install.RunAsync(LetPortal.Tools.ToolsContext)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1303:Method 'Task Uninstall.RunAsync(ToolsContext context)' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"Oops we don't find any installation in the database.\".", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Uninstall.RunAsync(LetPortal.Tools.ToolsContext)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'Uninstall.UninstallingVersion(IEnumerable<IVersion>, ToolsContext)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Uninstall.UninstallingVersion(System.Collections.Generic.IEnumerable{LetPortal.Core.Versions.IVersion},LetPortal.Tools.ToolsContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1303:Method 'Task Upgrade.RunAsync(ToolsContext context)' passes a literal string as parameter 'value' of a call to 'void Console.WriteLine(string value)'. Retrieve the following string(s) from a resource table instead: \"Oops we can't find any installation in the database, please use 'install' command before upgrading.\".", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Upgrade.RunAsync(LetPortal.Tools.ToolsContext)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'Upgrade.RunAsync(ToolsContext)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Upgrade.RunAsync(LetPortal.Tools.ToolsContext)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'Upgrade.UpgradingVersion(IEnumerable<IVersion>, ToolsContext)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:LetPortal.Tools.Features.Upgrade.UpgradingVersion(System.Collections.Generic.IEnumerable{LetPortal.Core.Versions.IVersion},LetPortal.Tools.ToolsContext)~System.Collections.Generic.List{LetPortal.Core.Versions.Version}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:Downgrade is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "<Pending>", Scope = "type", Target = "~T:LetPortal.Tools.Features.Downgrade")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:Info is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "<Pending>", Scope = "type", Target = "~T:LetPortal.Tools.Features.Info")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:Install is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "<Pending>", Scope = "type", Target = "~T:LetPortal.Tools.Features.Install")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:Patch is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "<Pending>", Scope = "type", Target = "~T:LetPortal.Tools.Features.Patch")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:Uninstall is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "<Pending>", Scope = "type", Target = "~T:LetPortal.Tools.Features.Uninstall")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1812:Upgrade is an internal class that is apparently never instantiated. If so, remove the code from the assembly. If this class is intended to contain only static members, make it static (Shared in Visual Basic).", Justification = "<Pending>", Scope = "type", Target = "~T:LetPortal.Tools.Features.Upgrade")]