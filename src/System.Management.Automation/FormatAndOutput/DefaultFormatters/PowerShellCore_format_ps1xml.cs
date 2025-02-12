// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class PowerShellCore_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            var AvailableModules_GroupingFormat = CustomControl.Create()
                    .StartEntry()
                        .StartFrame()
                            .AddText(FileSystemProviderStrings.DirectoryDisplayGrouping)
                            .AddScriptBlockExpressionBinding(@"Split-Path -Parent $_.Path | ForEach-Object { if([Version]::TryParse((Split-Path $_ -Leaf), [ref]$null)) { Split-Path -Parent $_} else {$_} } | Split-Path -Parent")
                        .EndFrame()
                    .EndEntry()
                .EndControl();

            var sharedControls = new CustomControl[] {
                AvailableModules_GroupingFormat
            };

            yield return new ExtendedTypeDefinition(
                "System.RuntimeType",
                ViewsOf_System_RuntimeType());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.MemberDefinition",
                ViewsOf_Microsoft_PowerShell_Commands_MemberDefinition());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.GroupInfo",
                ViewsOf_Microsoft_PowerShell_Commands_GroupInfo());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.GroupInfoNoElement",
                ViewsOf_Microsoft_PowerShell_Commands_GroupInfoNoElement());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.HistoryInfo",
                ViewsOf_Microsoft_PowerShell_Commands_HistoryInfo());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.MatchInfo",
                ViewsOf_Microsoft_PowerShell_Commands_MatchInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.PSVariable",
                ViewsOf_System_Management_Automation_PSVariable());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.PathInfo",
                ViewsOf_System_Management_Automation_PathInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.CommandInfo",
                ViewsOf_System_Management_Automation_CommandInfo());

            var td10 = new ExtendedTypeDefinition(
                "System.Management.Automation.AliasInfo",
                ViewsOf_System_Management_Automation_AliasInfo_System_Management_Automation_ApplicationInfo_System_Management_Automation_CmdletInfo_System_Management_Automation_ExternalScriptInfo_System_Management_Automation_FilterInfo_System_Management_Automation_FunctionInfo_System_Management_Automation_ScriptInfo());
            td10.TypeNames.Add("System.Management.Automation.ApplicationInfo");
            td10.TypeNames.Add("System.Management.Automation.CmdletInfo");
            td10.TypeNames.Add("System.Management.Automation.ExternalScriptInfo");
            td10.TypeNames.Add("System.Management.Automation.FilterInfo");
            td10.TypeNames.Add("System.Management.Automation.FunctionInfo");
            td10.TypeNames.Add("System.Management.Automation.ScriptInfo");
            yield return td10;

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.Runspaces.TypeData",
                ViewsOf_System_Management_Automation_Runspaces_TypeData());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.ControlPanelItem",
                ViewsOf_Microsoft_PowerShell_Commands_ControlPanelItem());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.ApplicationInfo",
                ViewsOf_System_Management_Automation_ApplicationInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.ScriptInfo",
                ViewsOf_System_Management_Automation_ScriptInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.ExternalScriptInfo",
                ViewsOf_System_Management_Automation_ExternalScriptInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.FunctionInfo",
                ViewsOf_System_Management_Automation_FunctionInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.FilterInfo",
                ViewsOf_System_Management_Automation_FilterInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.AliasInfo",
                ViewsOf_System_Management_Automation_AliasInfo());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.ListCommand+MemberInfo",
                ViewsOf_Microsoft_PowerShell_Commands_ListCommand_MemberInfo());

            var td20 = new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.ActiveDirectoryProvider+ADPSDriveInfo",
                ViewsOf_Microsoft_PowerShell_Commands_ActiveDirectoryProvider_ADPSDriveInfo_System_Management_Automation_PSDriveInfo());
            td20.TypeNames.Add("System.Management.Automation.PSDriveInfo");
            yield return td20;

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.ProviderInfo",
                ViewsOf_System_Management_Automation_ProviderInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.CmdletInfo",
                ViewsOf_System_Management_Automation_CmdletInfo());

            var td23 = new ExtendedTypeDefinition(
                "System.Management.Automation.FilterInfo",
                ViewsOf_System_Management_Automation_FilterInfo_System_Management_Automation_FunctionInfo());
            td23.TypeNames.Add("System.Management.Automation.FunctionInfo");
            yield return td23;

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.PSDriveInfo",
                ViewsOf_System_Management_Automation_PSDriveInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.ShellVariable",
                ViewsOf_System_Management_Automation_ShellVariable());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.ScriptBlock",
                ViewsOf_System_Management_Automation_ScriptBlock());

            yield return new ExtendedTypeDefinition(
                "PSExtendedError",
                ViewsOf_System_Management_Automation_GetError());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.ErrorRecord",
                ViewsOf_System_Management_Automation_ErrorRecord());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.WarningRecord",
                ViewsOf_System_Management_Automation_WarningRecord());

            yield return new ExtendedTypeDefinition(
                "Deserialized.System.Management.Automation.WarningRecord",
                ViewsOf_Deserialized_System_Management_Automation_WarningRecord());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.InformationRecord",
                ViewsOf_System_Management_Automation_InformationRecord());

            yield return new ExtendedTypeDefinition(
                "System.Exception",
                ViewsOf_System_Exception());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.CommandParameterSetInfo",
                ViewsOf_System_Management_Automation_CommandParameterSetInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.Runspaces.Runspace",
                ViewsOf_System_Management_Automation_Runspaces_Runspace());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.Runspaces.PSSession",
                ViewsOf_System_Management_Automation_Runspaces_PSSession());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.Job",
                ViewsOf_System_Management_Automation_Job());

            yield return new ExtendedTypeDefinition(
                "Deserialized.Microsoft.PowerShell.Commands.TextMeasureInfo",
                ViewsOf_Deserialized_Microsoft_PowerShell_Commands_TextMeasureInfo());

            yield return new ExtendedTypeDefinition(
                "Deserialized.Microsoft.PowerShell.Commands.GenericMeasureInfo",
                ViewsOf_Deserialized_Microsoft_PowerShell_Commands_GenericMeasureInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.CallStackFrame",
                ViewsOf_System_Management_Automation_CallStackFrame());

            var td40 = new ExtendedTypeDefinition(
                "System.Management.Automation.CommandBreakpoint",
                ViewsOf_BreakpointTypes());
            td40.TypeNames.Add("System.Management.Automation.LineBreakpoint");
            td40.TypeNames.Add("System.Management.Automation.VariableBreakpoint");
            yield return td40;

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.PSSessionConfigurationCommands#PSSessionConfiguration",
                ViewsOf_Microsoft_PowerShell_Commands_PSSessionConfigurationCommands_PSSessionConfiguration());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.ComputerChangeInfo",
                ViewsOf_Microsoft_PowerShell_Commands_ComputerChangeInfo());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.RenameComputerChangeInfo",
                ViewsOf_Microsoft_PowerShell_Commands_RenameComputerChangeInfo());

            yield return new ExtendedTypeDefinition(
                "ModuleInfoGrouping",
                ViewsOf_ModuleInfoGrouping(sharedControls));

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.PSModuleInfo",
                ViewsOf_System_Management_Automation_PSModuleInfo());

            yield return new ExtendedTypeDefinition(
                "System.Management.Automation.ExperimentalFeature",
                ViewsOf_System_Management_Automation_ExperimentalFeature());

            var td46 = new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.BasicHtmlWebResponseObject",
                ViewsOf_Microsoft_PowerShell_Commands_BasicHtmlWebResponseObject());
            yield return td46;

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.WebResponseObject",
                ViewsOf_Microsoft_PowerShell_Commands_WebResponseObject());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.FileHashInfo",
                ViewsOf_Microsoft_Powershell_Utility_FileHashInfo());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.PSRunspaceDebug",
                ViewsOf_Microsoft_PowerShell_Commands_PSRunspaceDebug());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.MarkdownRender.PSMarkdownOptionInfo",
                ViewsOf_Microsoft_PowerShell_MarkdownRender_MarkdownOptionInfo());

            yield return new ExtendedTypeDefinition(
                "Microsoft.PowerShell.Commands.ByteCollection",
                ViewsOf_Microsoft_PowerShell_Commands_ByteCollection());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_RuntimeType()
        {
            yield return new FormatViewDefinition("System.RuntimeType",
                TableControl.Create()
                    .AddHeader(label: "IsPublic", width: 8)
                    .AddHeader(label: "IsSerial", width: 8)
                    .AddHeader(width: 40)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("IsPublic")
                        .AddPropertyColumn("IsSerializable")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("BaseType")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_MemberDefinition()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.MemberDefinition",
                TableControl.Create(autoSize: true)
                    .GroupByProperty("TypeName")
                    .AddHeader(label: "Name")
                    .AddHeader(label: "MemberType")
                    .AddHeader(label: "Definition")
                    .StartRowDefinition()
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("MemberType")
                        .AddPropertyColumn("Definition")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_GroupInfo()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.GroupInfo",
                TableControl.Create()
                    .AddHeader(Alignment.Right, label: "Count", width: 5)
                    .AddHeader(width: 25)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("Count")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Group")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.GroupInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"Count")
                        .AddItemProperty(@"Group")
                        .AddItemProperty(@"Values")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_GroupInfoNoElement()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.GroupInfoNoElement",
                TableControl.Create()
                    .AddHeader(Alignment.Right, label: "Count", width: 5)
                    .AddHeader(width: 25)
                    .StartRowDefinition()
                        .AddPropertyColumn("Count")
                        .AddPropertyColumn("Name")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.GroupInfoNoElement",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"Count")
                        .AddItemProperty(@"Values")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_HistoryInfo()
        {
            yield return new FormatViewDefinition("history",
                TableControl.Create()
                    .AddHeader(Alignment.Right, width: 4)
                    .AddHeader(Alignment.Right, label: "Duration", width: 12)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("Id")
                        .AddScriptBlockColumn(@"
                                if ($_.Duration.TotalHours -ge 10) {
                                    return ""{0}:{1:mm}:{1:ss}.{1:fff}"" -f [int]$_.Duration.TotalHours, $_.Duration
                                }
                                elseif ($_.Duration.TotalHours -ge 1) {
                                    $formatString = ""h\:mm\:ss\.fff""
                                }
                                elseif ($_.Duration.TotalMinutes -ge 1) {
                                    $formatString = ""m\:ss\.fff""
                                }
                                else {
                                    $formatString = ""s\.fff""
                                }

                                $_.Duration.ToString($formatString)
                              ")
                        .AddPropertyColumn("CommandLine")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("history",
                WideControl.Create()
                    .AddPropertyEntry("CommandLine")
                .EndWideControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_MatchInfo()
        {
            yield return new FormatViewDefinition("MatchInfo",
                CustomControl.Create()
                    .StartEntry()
                        .AddScriptBlockExpressionBinding(@"$_.ToEmphasizedString(((get-location).path))")
                    .EndEntry()
                .EndControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSVariable()
        {
            yield return new FormatViewDefinition("Variable",
                TableControl.Create()
                    .AddHeader(width: 30)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Value")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PathInfo()
        {
            yield return new FormatViewDefinition("PathInfo",
                TableControl.Create()
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("Path")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_CommandInfo()
        {
            yield return new FormatViewDefinition("CommandInfo",
                TableControl.Create()
                    .AddHeader(width: 15)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("CommandType")
                        .AddPropertyColumn("Name")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_AliasInfo_System_Management_Automation_ApplicationInfo_System_Management_Automation_CmdletInfo_System_Management_Automation_ExternalScriptInfo_System_Management_Automation_FilterInfo_System_Management_Automation_FunctionInfo_System_Management_Automation_ScriptInfo()
        {
            yield return new FormatViewDefinition("CommandInfo",
                TableControl.Create()
                    .AddHeader(label: "CommandType", width: 15)
                    .AddHeader(label: "Name", width: 50)
                    .AddHeader(label: "Version", width: 10)
                    .AddHeader(label: "Source")
                    .StartRowDefinition()
                        .AddPropertyColumn("CommandType")
                        .AddScriptBlockColumn(@"
                                if ($_.CommandType -eq ""Alias"")
                                {
                                  $_.DisplayName
                                }
                                else
                                {
                                  $_.Name
                                }
                              ")
                        .AddPropertyColumn("Version")
                        .AddPropertyColumn("Source")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Runspaces_TypeData()
        {
            yield return new FormatViewDefinition("TypeData",
                TableControl.Create()
                    .AddHeader(label: "TypeName")
                    .AddHeader(label: "Members")
                    .StartRowDefinition()
                        .AddPropertyColumn("TypeName")
                        .AddPropertyColumn("Members")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ControlPanelItem()
        {
            yield return new FormatViewDefinition("ControlPanelItem",
                TableControl.Create()
                    .AddHeader(label: "Name")
                    .AddHeader(label: "CanonicalName")
                    .AddHeader(label: "Category")
                    .AddHeader(label: "Description")
                    .StartRowDefinition()
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("CanonicalName")
                        .AddPropertyColumn("Category")
                        .AddPropertyColumn("Description")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ApplicationInfo()
        {
            yield return new FormatViewDefinition("ApplicationInfo",
                TableControl.Create()
                    .AddHeader(width: 15)
                    .AddHeader()
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("CommandType")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Path")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("System.Management.Automation.ApplicationInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"CommandType")
                        .AddItemProperty(@"Definition")
                        .AddItemProperty(@"Extension")
                        .AddItemProperty(@"Path")
                        .AddItemProperty(@"FileVersionInfo")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ScriptInfo()
        {
            yield return new FormatViewDefinition("ScriptInfo",
                TableControl.Create()
                    .AddHeader(width: 15)
                    .AddHeader()
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("CommandType")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Definition")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("System.Management.Automation.ScriptInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"CommandType")
                        .AddItemProperty(@"Definition")
                        .AddItemProperty(@"Path")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ExternalScriptInfo()
        {
            yield return new FormatViewDefinition("ExternalScriptInfo",
                TableControl.Create()
                    .AddHeader(width: 15)
                    .AddHeader()
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("CommandType")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Path")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_FunctionInfo()
        {
            yield return new FormatViewDefinition("FunctionInfo",
                TableControl.Create()
                    .AddHeader(width: 15)
                    .AddHeader()
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("CommandType")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Function")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_FilterInfo()
        {
            yield return new FormatViewDefinition("FilterInfo",
                TableControl.Create()
                    .AddHeader(width: 15)
                    .AddHeader()
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("CommandType")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Filter")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_AliasInfo()
        {
            yield return new FormatViewDefinition("AliasInfo",
                TableControl.Create()
                    .AddHeader(width: 15)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("CommandType")
                        .AddPropertyColumn("DisplayName")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("System.Management.Automation.AliasInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"DisplayName")
                        .AddItemProperty(@"CommandType")
                        .AddItemProperty(@"Definition")
                        .AddItemProperty(@"ReferencedCommand")
                        .AddItemProperty(@"ResolvedCommand")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ListCommand_MemberInfo()
        {
            yield return new FormatViewDefinition("memberinfo",
                TableControl.Create()
                    .AddHeader(label: "Class", width: 11)
                    .AddHeader(width: 25)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("MemberClass")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("MemberData")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.ListCommand+MemberInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"MemberClass")
                        .AddItemProperty(@"MemberData")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ActiveDirectoryProvider_ADPSDriveInfo_System_Management_Automation_PSDriveInfo()
        {
            yield return new FormatViewDefinition("drive",
                TableControl.Create()
                    .AddHeader(width: 10)
                    .AddHeader(label: "Used (GB)", width: 13)
                    .AddHeader(label: "Free (GB)", width: 13)
                    .AddHeader(label: "Provider", width: 13)
                    .AddHeader(label: "Root", width: 35)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("Name")
                        .AddScriptBlockColumn(@"if($_.Used -or $_.Free) { ""{0:###0.00}"" -f ($_.Used / 1GB) }", alignment: Alignment.Right)
                        .AddScriptBlockColumn(@"if($_.Used -or $_.Free) { ""{0:###0.00}"" -f ($_.Free / 1GB) }", alignment: Alignment.Right)
                        .AddScriptBlockColumn("$_.Provider.Name")
                        .AddScriptBlockColumn("if($null -ne $_.DisplayRoot) { $_.DisplayRoot } else { $_.Root }")
                        .AddPropertyColumn("CurrentLocation", alignment: Alignment.Right)
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ProviderInfo()
        {
            yield return new FormatViewDefinition("provider",
                TableControl.Create()
                    .AddHeader(width: 20)
                    .AddHeader()
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Capabilities")
                        .AddPropertyColumn("Drives")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("provider",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"Drives")
                        .AddItemProperty(@"Path")
                        .AddItemProperty(@"Home")
                        .AddItemProperty(@"Description")
                        .AddItemProperty(@"Capabilities")
                        .AddItemProperty(@"ImplementingType")
                        .AddItemProperty(@"AssemblyInfo")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_CmdletInfo()
        {
            yield return new FormatViewDefinition("System.Management.Automation.CmdletInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"CommandType")
                        .AddItemProperty(@"Definition")
                        .AddItemProperty(@"Path")
                        .AddItemProperty(@"AssemblyInfo")
                        .AddItemProperty(@"DLL")
                        .AddItemProperty(@"HelpFile")
                        .AddItemProperty(@"ParameterSets")
                        .AddItemProperty(@"ImplementingType")
                        .AddItemProperty(@"Verb")
                        .AddItemProperty(@"Noun")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_FilterInfo_System_Management_Automation_FunctionInfo()
        {
            yield return new FormatViewDefinition("System.Management.Automation.CommandInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"CommandType")
                        .AddItemProperty(@"Definition")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSDriveInfo()
        {
            yield return new FormatViewDefinition("System.Management.Automation.PSDriveInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"Description")
                        .AddItemProperty(@"Provider")
                        .AddItemProperty(@"Root")
                        .AddItemProperty(@"CurrentLocation")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ShellVariable()
        {
            yield return new FormatViewDefinition("ShellVariable",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"Value")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ScriptBlock()
        {
            yield return new FormatViewDefinition("ScriptBlock",
                CustomControl.Create(outOfBand: true)
                    .StartEntry()
                        .AddScriptBlockExpressionBinding(@"$_")
                    .EndEntry()
                .EndControl());
        }

        // This generates a custom view for ErrorRecords and Exceptions making
        // specific nested types defined in $expandTypes visible.  It also handles
        // IEnumerable types.  Nested types are indented by 4 spaces.
        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_GetError()
        {
            yield return new FormatViewDefinition("GetErrorInstance",
                CustomControl.Create()
                    .GroupByProperty("PSErrorIndex", label: "ErrorIdentifier")
                    .StartEntry()
                        .AddScriptBlockExpressionBinding(@"
                            $maxDepth = 10
                            $ellipsis = ""`u{2026}""
                            $resetColor = ''
                            if ($Host.UI.SupportsVirtualTerminal) {
                                $resetColor = ""`e[0m""
                            }

                            function Get-VT100Color([string] $color) {
                                if (! $Host.UI.SupportsVirtualTerminal) {
                                    return ''
                                }

                                $colors = @{
                                    'Black' = ""`e[2;30m""
                                    'DarkRed' = ""`e[2;31m""
                                    'DarkGreen' = ""`e[2;32m""
                                    'DarkYellow' = ""`e[2;33m""
                                    'DarkBlue' = ""`e[2;34m""
                                    'DarkMagenta' = ""`e[2;35m""
                                    'DarkCyan' = ""`e[2;36m""
                                    'Gray' = ""`e[2;37m""
                                    'DarkGray' = ""`e[1;30m""
                                    'Red' = ""`e[1;31m""
                                    'Green' = ""`e[1;32m""
                                    'Yellow' = ""`e[1;33m""
                                    'Blue' = ""`e[1;34m""
                                    'Magenta' = ""`e[1;35m""
                                    'Cyan' = ""`e[1;36m""
                                    'White' = ""`e[1;37m""
                                }

                                return $colors[$color]
                            }

                            function Show-ErrorRecord($obj, [int]$indent = 0, [int]$depth = 1) {
                                $newline = [Environment]::Newline
                                $output = [System.Text.StringBuilder]::new()
                                $prefix = ' ' * $indent
                                $accentColor = Get-VT100Color $Host.PrivateData.FormatAccentColor
                                $expandTypes = @(
                                    'Microsoft.Rest.HttpRequestMessageWrapper'
                                    'Microsoft.Rest.HttpResponseMessageWrapper'
                                    'System.Management.Automation.InvocationInfo'
                                )

                                # first find the longest property so we can indent properly
                                $propLength = 0
                                foreach ($prop in $obj.PSObject.Properties) {
                                    if ($prop.Value -ne $null -and $prop.Value -ne [string]::Empty -and $prop.Name.Length -gt $propLength) {
                                        $propLength = $prop.Name.Length
                                    }
                                }

                                $addedProperty = $false
                                foreach ($prop in $obj.PSObject.Properties) {

                                    # don't show empty properties or our added property for $error[index]
                                    if ($prop.Value -ne $null -and $prop.Value -ne [string]::Empty -and $prop.Value.count -gt 0 -and $prop.Name -ne 'PSErrorIndex') {
                                        $addedProperty = $true
                                        $null = $output.Append($prefix)
                                        $null = $output.Append($accentColor)
                                        $null = $output.Append($prop.Name)
                                        $propNameIndent = ' ' * ($propLength - $prop.Name.Length)
                                        $null = $output.Append($propNameIndent)
                                        $null = $output.Append(' : ')
                                        $null = $output.Append($resetColor)

                                        $newIndent = $indent + 4

                                        # only show nested objects that are Exceptions, ErrorRecords, or types defined in $expandTypes and types not in $ignoreTypes
                                        if ($prop.Value -is [Exception] -or $prop.Value -is [System.Management.Automation.ErrorRecord] -or
                                            $expandTypes -contains $prop.TypeNameOfValue -or ($prop.TypeNames -ne $null -and $expandTypes -contains $prop.TypeNames[0])) {

                                            if ($depth -ge $maxDepth) {
                                                $null = $output.Append($ellipsis)
                                            }
                                            else {
                                                $null = $output.Append($newline)
                                                $null = $output.Append((Show-ErrorRecord $prop.Value $newIndent ($depth + 1)))
                                            }
                                        }
                                        # `TargetSite` has many members that are not useful visually, so we have a reduced view of the relevant members
                                        elseif ($prop.Name -eq 'TargetSite' -and $prop.Value.GetType().Name -eq 'RuntimeMethodInfo') {
                                            if ($depth -ge $maxDepth) {
                                                $null = $output.Append($ellipsis)
                                            }
                                            else {
                                                $targetSite = [PSCustomObject]@{
                                                    Name = $prop.Value.Name
                                                    DeclaringType = $prop.Value.DeclaringType
                                                    MemberType = $prop.Value.MemberType
                                                    Module = $prop.Value.Module
                                                }

                                                $null = $output.Append($newline)
                                                $null = $output.Append((Show-ErrorRecord $targetSite $newIndent ($depth + 1)))
                                            }
                                        }
                                        # `StackTrace` is handled specifically because the lines are typically long but necessary so they are left justified without additional indentation
                                        elseif ($prop.Name -eq 'StackTrace') {
                                            # for a stacktrace which is usually quite wide with info, we left justify it
                                            $null = $output.Append($newline)
                                            $null = $output.Append($prop.Value)
                                        }
                                        # Dictionary and Hashtable we want to show as Key/Value pairs, we don't do the extra whitespace alignment here
                                        elseif ($prop.Value.GetType().Name.StartsWith('Dictionary') -or $prop.Value.GetType().Name -eq 'Hashtable') {
                                            $isFirstElement = $true
                                            foreach ($key in $prop.Value.Keys) {
                                                if ($isFirstElement) {
                                                    $null = $output.Append($newline)
                                                }

                                                if ($key -eq 'Authorization') {
                                                    $null = $output.Append(""${prefix}    ${accentColor}${key} : ${resetColor}${ellipsis}${newline}"")
                                                }
                                                else {
                                                    $null = $output.Append(""${prefix}    ${accentColor}${key} : ${resetColor}$($prop.Value[$key])${newline}"")
                                                }

                                                $isFirstElement = $false
                                            }
                                        }
                                        # if the object implements IEnumerable and not a string, we try to show each object
                                        # We ignore the `Data` property as it can contain lots of type information by the interpreter that isn't useful here
                                        elseif (!($prop.Value -is [System.String]) -and $prop.Value.GetType().GetInterface('IEnumerable') -ne $null -and $prop.Name -ne 'Data') {

                                            if ($depth -ge $maxDepth) {
                                                $null = $output.Append($ellipsis)
                                            }
                                            else {
                                                $isFirstElement = $true
                                                foreach ($value in $prop.Value) {
                                                    $null = $output.Append($newline)
                                                    if (!$isFirstElement) {
                                                        $null = $output.Append($newline)
                                                    }
                                                    $null = $output.Append((Show-ErrorRecord $value $newIndent ($depth + 1)))
                                                    $isFirstElement = $false
                                                }
                                            }
                                        }
                                        # anything else, we use ToString()
                                        else {
                                            $value = $prop.Value.ToString().Trim()

                                            $isFirstLine = $true
                                            if ($value.Contains($newline)) {
                                                # the 3 is to account for ' : '
                                                $valueIndent = ' ' * ($propLength + 3)
                                                # need to trim any extra whitespace already in the text
                                                foreach ($line in $value.Split($newline)) {
                                                    if (!$isFirstLine) {
                                                        $null = $output.Append(""${newline}${prefix}${valueIndent}"")
                                                    }
                                                    $null = $output.Append($line.Trim())
                                                    $isFirstLine = $false
                                                }
                                            }
                                            else {
                                                $null = $output.Append($value)
                                            }
                                        }

                                        $null = $output.Append($newline)
                                    }
                                }

                                # if we had added nested properties, we need to remove the last newline
                                if ($addedProperty) {
                                    $null = $output.Remove($output.Length - $newline.Length, $newline.Length)
                                }

                                $output.ToString()
                            }

                            Show-ErrorRecord $_
                        ")
                    .EndEntry()
                .EndControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ErrorRecord()
        {
            yield return new FormatViewDefinition("ErrorInstance",
                CustomControl.Create(outOfBand: true)
                    .StartEntry()
                        .AddScriptBlockExpressionBinding(@"
                                    if (@('NativeCommandErrorMessage','NativeCommandError') -notcontains $_.FullyQualifiedErrorId -and @('CategoryView','ConciseView') -notcontains $ErrorView)
                                    {
                                        $myinv = $_.InvocationInfo
                                        if ($myinv -and $myinv.MyCommand)
                                        {
                                            switch -regex ( $myinv.MyCommand.CommandType )
                                            {
                                                ([System.Management.Automation.CommandTypes]::ExternalScript)
                                                {
                                                    if ($myinv.MyCommand.Path)
                                                    {
                                                        $myinv.MyCommand.Path + ' : '
                                                    }

                                                    break
                                                }

                                                ([System.Management.Automation.CommandTypes]::Script)
                                                {
                                                    if ($myinv.MyCommand.ScriptBlock)
                                                    {
                                                        $myinv.MyCommand.ScriptBlock.ToString() + ' : '
                                                    }

                                                    break
                                                }
                                                default
                                                {
                                                    if ($myinv.InvocationName -match '^[&\.]?$')
                                                    {
                                                        if ($myinv.MyCommand.Name)
                                                        {
                                                            $myinv.MyCommand.Name + ' : '
                                                        }
                                                    }
                                                    else
                                                    {
                                                        $myinv.InvocationName + ' : '
                                                    }

                                                    break
                                                }
                                            }
                                        }
                                        elseif ($myinv -and $myinv.InvocationName)
                                        {
                                            $myinv.InvocationName + ' : '
                                        }
                                    }
                                ")
                        .AddScriptBlockExpressionBinding(@"

                                    function Get-ConciseViewPositionMessage {
                                        Set-StrictMode -Off

                                        $resetColor = ''
                                        if ($Host.UI.SupportsVirtualTerminal) {
                                            $resetColor = ""`e[0m""
                                        }

                                        function Get-VT100Color([string] $color) {
                                            if (! $Host.UI.SupportsVirtualTerminal) {
                                                return ''
                                            }

                                            $colors = @{
                                                'Black' = ""`e[2;30m""
                                                'DarkRed' = ""`e[2;31m""
                                                'DarkGreen' = ""`e[2;32m""
                                                'DarkYellow' = ""`e[2;33m""
                                                'DarkBlue' = ""`e[2;34m""
                                                'DarkMagenta' = ""`e[2;35m""
                                                'DarkCyan' = ""`e[2;36m""
                                                'Gray' = ""`e[2;37m""
                                                'DarkGray' = ""`e[1;30m""
                                                'Red' = ""`e[1;31m""
                                                'Green' = ""`e[1;32m""
                                                'Yellow' = ""`e[1;33m""
                                                'Blue' = ""`e[1;34m""
                                                'Magenta' = ""`e[1;35m""
                                                'Cyan' = ""`e[1;36m""
                                                'White' = ""`e[1;37m""
                                            }

                                            return $colors[$color]
                                        }

                                        # return length of string sans VT100 codes
                                        function Get-RawStringLength($string) {
                                            $vtCodes = ""`e[0m"", ""`e[2;30m"", ""`e[2;31m"", ""`e[2;32m"", ""`e[2;33m"", ""`e[2;34m"",
                                                ""`e[2;35m"", ""`e[2;36m"", ""`e[2;37m"", ""`e[1;30m"", ""`e[1;31m"", ""`e[1;32m"",
                                                ""`e[1;33m"", ""`e[1;34m"", ""`e[1;35m"", ""`e[1;36m"", ""`e[1;37m""

                                            $newString = $string
                                            foreach ($vtCode in $vtCodes) {
                                                $newString = $newString.Replace($vtCode, '')
                                            }

                                            return $newString.Length
                                        }

                                        # returns a string cut to last whitespace
                                        function Get-TruncatedString($string, [int]$length) {

                                            if ($string.Length -le $length) {
                                                return $string
                                            }

                                            return ($string.Substring(0,$length) -split '\s',-2)[0]
                                        }

                                        $errorColor = ''
                                        $accentColor = ''
                                        if ($Host.PrivateData) {
                                            $errorColor = Get-VT100Color -color $Host.PrivateData.ErrorForegroundColor
                                            $accentColor = Get-VT100Color -color $Host.PrivateData.ErrorAccentColor
                                        }

                                        $posmsg = ''
                                        $headerWhitespace = ''
                                        $offsetWhitespace = ''
                                        $message = ''
                                        $prefix = ''
                                        $newline = [Environment]::Newline

                                        if ($myinv -and $myinv.ScriptName -or $myinv.ScriptLineNumber -gt 1 -or $_.CategoryInfo.Category -eq 'ParserError') {
                                            if ($myinv.ScriptName) {
                                                $posmsg = ""${resetcolor}$($myinv.ScriptName)${newline}""
                                            }
                                            else {
                                                $posmsg = ""${newline}""
                                            }

                                            $scriptLineNumberLength = $myinv.ScriptLineNumber.ToString().Length
                                            if ($scriptLineNumberLength -gt 4) {
                                                $headerWhitespace = ' ' * ($scriptLineNumberLength - 4)
                                            }

                                            $lineWhitespace = ''
                                            if ($scriptLineNumberLength -lt 4) {
                                                $lineWhitespace = ' ' * (4 - $scriptLineNumberLength)
                                            }

                                            $verticalBar = '|'
                                            $posmsg += ""${accentColor}${headerWhitespace}Line ${verticalBar}${newline}""
                                            $line = $myinv.Line
                                            $highlightLine = $myinv.PositionMessage.Split('+').Count - 1
                                            $offsetLength = $myinv.PositionMessage.split('+')[$highlightLine].Trim().Length

                                            # don't color the whole line red
                                            if ($offsetLength -lt $line.Length - 1) {
                                                $line = $line.Insert($myinv.OffsetInLine - 1 + $offsetLength, $resetColor).Insert($myinv.OffsetInLine - 1, $accentColor)
                                            }

                                            $posmsg += ""${accentColor}${lineWhitespace}$($myinv.ScriptLineNumber) ${verticalBar} ${resetcolor}${line}`n""
                                            $offsetWhitespace = ' ' * ($myinv.OffsetInLine - 1)
                                            $prefix = ""${accentColor}${headerWhitespace}     ${verticalBar} ${errorColor}""
                                            $message = ""${prefix}${offsetWhitespace}^ ""
                                        }

                                        if (! $_.ErrorDetails -or ! $_.ErrorDetails.Message) {
                                            # we use `n instead of $newline here because that's what is in the message
                                            if ($_.CategoryInfo.Category -eq 'ParserError' -and $_.Exception.Message.Contains(""~`n"")) {
                                                # need to parse out the relevant part of the pre-rendered positionmessage
                                                $message += $_.Exception.Message.split(""~`n"")[1].split(""${newline}${newline}"")[0]
                                            }
                                            else {
                                                $message += $_.Exception.Message
                                            }
                                        }
                                        else {
                                            $message += $_.ErrorDetails.Message
                                        }

                                        # if rendering line information, break up the message if it's wider than the console
                                        if ($myinv -and $myinv.ScriptName -or $_.CategoryInfo.Category -eq 'ParserError') {
                                            $prefixLength = Get-RawStringLength -string $prefix
                                            $prefixVtLength = $prefix.Length - $prefixLength

                                            # replace newlines in message so it lines up correct
                                            $message = $message.Replace($newline, ' ').Replace(""`t"", ' ')
                                            if ([Console]::WindowWidth -gt 0 -and ($message.Length - $prefixVTLength) -gt [Console]::WindowWidth) {
                                                $sb = [Text.StringBuilder]::new()
                                                $substring = Get-TruncatedString -string $message -length ([Console]::WindowWidth + $prefixVTLength)
                                                $null = $sb.Append($substring)
                                                $remainingMessage = $message.Substring($substring.Length).Trim()
                                                $null = $sb.Append($newline)
                                                while (($remainingMessage.Length + $prefixLength) -gt [Console]::WindowWidth) {
                                                    $subMessage = $prefix + $remainingMessage
                                                    $substring = Get-TruncatedString -string $subMessage -length ([Console]::WindowWidth + $prefixVtLength)
                                                    $null = $sb.Append($substring)
                                                    $null = $sb.Append($newline)
                                                    $remainingMessage = $remainingMessage.Substring($substring.Length - $prefix.Length).Trim()
                                                }
                                                $null = $sb.Append($prefix + $remainingMessage.Trim())
                                                $message = $sb.ToString()
                                            }

                                            $message += $newline
                                        }

                                        $posmsg += ""${errorColor}"" + $message

                                        $reason = 'Error'
                                        if ($_.Exception -and $_.Exception.WasThrownFromThrowStatement) {
                                            $reason = 'Exception'
                                        }
                                        elseif ($myinv.MyCommand) {
                                            $reason = $myinv.MyCommand
                                        }
                                        elseif ($myinv.InvocationName) {
                                            $reason = $myinv.InvocationName
                                        }
                                        elseif ($_.CategoryInfo.Category) {
                                            $reason = $_.CategoryInfo.Category
                                        }
                                        elseif ($_.CategoryInfo.Reason) {
                                            $reason = $_.CategoryInfo.Reason
                                        }

                                        $errorMsg = 'Error'

                                        ""${errorColor}${reason}: ${posmsg}${resetcolor}""
                                    }

                                    if ($_.FullyQualifiedErrorId -eq 'NativeCommandErrorMessage' -or $_.FullyQualifiedErrorId -eq 'NativeCommandError') {
                                        $_.Exception.Message
                                    }
                                    else
                                    {
                                        $myinv = $_.InvocationInfo
                                        if ($ErrorView -eq 'ConciseView') {
                                            $posmsg = Get-ConciseViewPositionMessage
                                        }
                                        elseif ($myinv -and ($myinv.MyCommand -or ($_.CategoryInfo.Category -ne 'ParserError'))) {
                                            $posmsg = $myinv.PositionMessage
                                        } else {
                                            $posmsg = ''
                                        }

                                        if ($posmsg -ne '')
                                        {
                                            $posmsg = ""`n"" + $posmsg
                                        }

                                        if ( & { Set-StrictMode -Version 1; $_.PSMessageDetails } ) {
                                            $posmsg = ' : ' +  $_.PSMessageDetails + $posmsg
                                        }

                                        if ($ErrorView -eq 'ConciseView') {
                                            return $posmsg
                                        }

                                        $indent = 4

                                        $errorCategoryMsg = & { Set-StrictMode -Version 1; $_.ErrorCategory_Message }

                                        if ($null -ne $errorCategoryMsg)
                                        {
                                            $indentString = '+ CategoryInfo          : ' + $_.ErrorCategory_Message
                                        }
                                        else
                                        {
                                            $indentString = '+ CategoryInfo          : ' + $_.CategoryInfo
                                        }

                                        $posmsg += ""`n"" + $indentString

                                        $indentString = ""+ FullyQualifiedErrorId : "" + $_.FullyQualifiedErrorId
                                        $posmsg += ""`n"" + $indentString

                                        $originInfo = & { Set-StrictMode -Version 1; $_.OriginInfo }

                                        if (($null -ne $originInfo) -and ($null -ne $originInfo.PSComputerName))
                                        {
                                            $indentString = ""+ PSComputerName        : "" + $originInfo.PSComputerName
                                            $posmsg += ""`n"" + $indentString
                                        }

                                        if ($ErrorView -eq 'CategoryView') {
                                            $_.CategoryInfo.GetMessage()
                                        }
                                        elseif (! $_.ErrorDetails -or ! $_.ErrorDetails.Message) {
                                            $_.Exception.Message + $posmsg + ""`n""
                                        } else {
                                            $_.ErrorDetails.Message + $posmsg
                                        }
                                    }
                                ")
                    .EndEntry()
                .EndControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_WarningRecord()
        {
            yield return new FormatViewDefinition("WarningRecord",
                CustomControl.Create(outOfBand: true)
                    .StartEntry()
                        .AddPropertyExpressionBinding(@"Message")
                    .EndEntry()
                .EndControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Deserialized_System_Management_Automation_WarningRecord()
        {
            yield return new FormatViewDefinition("DeserializedWarningRecord",
                CustomControl.Create(outOfBand: true)
                    .StartEntry()
                        .AddPropertyExpressionBinding(@"InformationalRecord_Message")
                    .EndEntry()
                .EndControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_InformationRecord()
        {
            yield return new FormatViewDefinition("InformationRecord",
                CustomControl.Create(outOfBand: true)
                    .StartEntry()
                        .AddScriptBlockExpressionBinding(@"$_.ToString()")
                    .EndEntry()
                .EndControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Exception()
        {
            yield return new FormatViewDefinition("Exception",
                CustomControl.Create(outOfBand: true)
                    .StartEntry()
                        .AddScriptBlockExpressionBinding(@"$_.Message")
                    .EndEntry()
                .EndControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_CommandParameterSetInfo()
        {
            var FmtParameterAttributes = CustomControl.Create()
                    .StartEntry()
                        .StartFrame(leftIndent: 2)
                            .AddNewline()
                        .EndFrame()
                    .EndEntry()
                .EndControl();

            var FmtParameterInfo = CustomControl.Create()
                    .StartEntry()
                        .AddNewline()
                        .StartFrame(leftIndent: 2)
                            .AddText("Parameter Name: ")
                            .AddPropertyExpressionBinding(@"Name")
                            .AddNewline()
                            .StartFrame(leftIndent: 2)
                                .AddText("ParameterType = ")
                                .AddPropertyExpressionBinding(@"ParameterType")
                                .AddNewline()
                                .AddText("Position = ")
                                .AddPropertyExpressionBinding(@"Position")
                                .AddNewline()
                                .AddText("IsMandatory = ")
                                .AddPropertyExpressionBinding(@"IsMandatory")
                                .AddNewline()
                                .AddText("IsDynamic = ")
                                .AddPropertyExpressionBinding(@"IsDynamic")
                                .AddNewline()
                                .AddText("HelpMessage = ")
                                .AddPropertyExpressionBinding(@"HelpMessage")
                                .AddNewline()
                                .AddText("ValueFromPipeline = ")
                                .AddPropertyExpressionBinding(@"ValueFromPipeline")
                                .AddNewline()
                                .AddText("ValueFromPipelineByPropertyName = ")
                                .AddPropertyExpressionBinding(@"ValueFromPipelineByPropertyName")
                                .AddNewline()
                                .AddText("ValueFromRemainingArguments = ")
                                .AddPropertyExpressionBinding(@"ValueFromRemainingArguments")
                                .AddNewline()
                                .AddText("Aliases = ")
                                .AddPropertyExpressionBinding(@"Aliases")
                                .AddNewline()
                                .AddText("Attributes =")
                                .AddNewline()
                                .AddPropertyExpressionBinding(@"Attributes", enumerateCollection: true, customControl: FmtParameterAttributes)
                            .EndFrame()
                        .EndFrame()
                    .EndEntry()
                .EndControl();

            yield return new FormatViewDefinition("CommandParameterSetInfo",
                CustomControl.Create()
                    .StartEntry()
                        .AddText("Parameter Set Name: ")
                        .AddPropertyExpressionBinding(@"Name")
                        .AddNewline()
                        .AddText("Is default parameter set: ")
                        .AddPropertyExpressionBinding(@"IsDefault")
                        .AddNewline()
                        .AddPropertyExpressionBinding(@"Parameters", enumerateCollection: true, customControl: FmtParameterInfo)
                        .AddNewline()
                    .EndEntry()
                .EndControl());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Runspaces_Runspace()
        {
            yield return new FormatViewDefinition("Runspace",
                TableControl.Create()
                    .AddHeader(Alignment.Right, label: "Id", width: 3)
                    .AddHeader(Alignment.Left, label: "Name", width: 15)
                    .AddHeader(Alignment.Left, label: "ComputerName", width: 15)
                    .AddHeader(Alignment.Left, label: "Type", width: 13)
                    .AddHeader(Alignment.Left, label: "State", width: 13)
                    .AddHeader(Alignment.Left, label: "Availability", width: 15)
                    .StartRowDefinition()
                        .AddPropertyColumn("Id")
                        .AddPropertyColumn("Name")
                        .AddScriptBlockColumn(@"
                    if ($null -ne $_.ConnectionInfo)
                    {
                      $_.ConnectionInfo.ComputerName
                    }
                    else
                    {
                      ""localhost""
                    }
                  ")
                        .AddScriptBlockColumn(@"
                    if ($null -ne $_.ConnectionInfo)
                    {
                      ""Remote""
                    }
                    else
                    {
                      ""Local""
                    }
                  ")
                        .AddScriptBlockColumn("$_.RunspaceStateInfo.State")
                        .AddScriptBlockColumn(@"
                    if (($null -ne $_.Debugger) -and ($_.Debugger.InBreakpoint))
                    {
                        ""InBreakpoint""
                    }
                    else
                    {
                        $_.RunspaceAvailability
                    }
                  ")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Runspaces_PSSession()
        {
            yield return new FormatViewDefinition("PSSession",
                TableControl.Create()
                    .AddHeader(Alignment.Right, label: "Id", width: 3)
                    .AddHeader(Alignment.Left, label: "Name", width: 15)
                    .AddHeader(Alignment.Left, label: "Transport", width: 9)
                    .AddHeader(Alignment.Left, label: "ComputerName", width: 15)
                    .AddHeader(Alignment.Left, label: "ComputerType", width: 15)
                    .AddHeader(Alignment.Left, label: "State", width: 13)
                    .AddHeader(Alignment.Left, label: "ConfigurationName", width: 20)
                    .AddHeader(Alignment.Right, label: "Availability", width: 13)
                    .StartRowDefinition()
                        .AddPropertyColumn("Id")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Transport")
                        .AddPropertyColumn("ComputerName")
                        .AddPropertyColumn("ComputerType")
                        .AddPropertyColumn("State")
                        .AddPropertyColumn("ConfigurationName")
                        .AddPropertyColumn("Availability")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Job()
        {
            yield return new FormatViewDefinition("Job",
                TableControl.Create()
                    .AddHeader(Alignment.Left, label: "Id", width: 6)
                    .AddHeader(Alignment.Left, label: "Name", width: 15)
                    .AddHeader(Alignment.Left, label: "PSJobTypeName", width: 15)
                    .AddHeader(Alignment.Left, label: "State", width: 13)
                    .AddHeader(Alignment.Left, label: "HasMoreData", width: 15)
                    .AddHeader(Alignment.Left, label: "Location", width: 20)
                    .AddHeader(Alignment.Left, label: "Command", width: 25)
                    .StartRowDefinition()
                        .AddPropertyColumn("Id")
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("PSJobTypeName")
                        .AddPropertyColumn("State")
                        .AddPropertyColumn("HasMoreData")
                        .AddPropertyColumn("Location")
                        .AddPropertyColumn("Command")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Deserialized_Microsoft_PowerShell_Commands_TextMeasureInfo()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.TextMeasureInfo",
                TableControl.Create()
                    .AddHeader(label: "Lines")
                    .AddHeader(label: "Words")
                    .AddHeader(label: "Characters")
                    .AddHeader(label: "Property")
                    .StartRowDefinition()
                        .AddPropertyColumn("Lines")
                        .AddPropertyColumn("Words")
                        .AddPropertyColumn("Characters")
                        .AddPropertyColumn("Property")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Deserialized_Microsoft_PowerShell_Commands_GenericMeasureInfo()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.GenericMeasureInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Count")
                        .AddItemProperty(@"Average")
                        .AddItemProperty(@"Sum")
                        .AddItemProperty(@"Maximum")
                        .AddItemProperty(@"Minimum")
                        .AddItemProperty(@"Property")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_CallStackFrame()
        {
            yield return new FormatViewDefinition("CallStackFrame",
                TableControl.Create()
                    .AddHeader(label: "Command")
                    .AddHeader(label: "Arguments")
                    .AddHeader(label: "Location")
                    .StartRowDefinition()
                        .AddPropertyColumn("Command")
                        .AddPropertyColumn("Arguments")
                        .AddPropertyColumn("Location")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_BreakpointTypes()
        {
            yield return new FormatViewDefinition("Breakpoint",
                TableControl.Create()
                    .AddHeader(Alignment.Right, label: "ID", width: 4)
                    .AddHeader(label: "Script")
                    .AddHeader(Alignment.Right, label: "Line", width: 4)
                    .AddHeader(label: "Command")
                    .AddHeader(label: "Variable")
                    .AddHeader(label: "Action")
                    .StartRowDefinition()
                        .AddPropertyColumn("ID")
                        .AddScriptBlockColumn("if ($_.Script) { [System.IO.Path]::GetFileName($_.Script) }")
                        .AddPropertyColumn("Line")
                        .AddPropertyColumn("Command")
                        .AddPropertyColumn("Variable")
                        .AddPropertyColumn("Action")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("Breakpoint",
                ListControl.Create()
                    .StartEntry(entrySelectedByType: new[] { "System.Management.Automation.LineBreakpoint" })
                        .AddItemProperty(@"ID")
                        .AddItemProperty(@"Script")
                        .AddItemProperty(@"Line")
                        .AddItemProperty(@"Column")
                        .AddItemProperty(@"Enabled")
                        .AddItemProperty(@"HitCount")
                        .AddItemProperty(@"Action")
                    .EndEntry()
                    .StartEntry(entrySelectedByType: new[] { "System.Management.Automation.VariableBreakpoint" })
                        .AddItemProperty(@"ID")
                        .AddItemProperty(@"Variable")
                        .AddItemProperty(@"AccessMode")
                        .AddItemProperty(@"Enabled")
                        .AddItemProperty(@"HitCount")
                        .AddItemProperty(@"Action")
                    .EndEntry()
                    .StartEntry(entrySelectedByType: new[] { "System.Management.Automation.CommandBreakpoint" })
                        .AddItemProperty(@"ID")
                        .AddItemProperty(@"Command")
                        .AddItemProperty(@"Enabled")
                        .AddItemProperty(@"HitCount")
                        .AddItemProperty(@"Action")
                    .EndEntry()
                    .StartEntry()
                        .AddItemProperty(@"ID")
                        .AddItemProperty(@"Script")
                        .AddItemProperty(@"Enabled")
                        .AddItemProperty(@"HitCount")
                        .AddItemProperty(@"Action")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_PSSessionConfigurationCommands_PSSessionConfiguration()
        {
            yield return new FormatViewDefinition("PSSessionConfiguration",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"PSVersion")
                        .AddItemProperty(@"StartupScript")
                        .AddItemProperty(@"RunAsUser")
                        .AddItemProperty(@"Permission")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ComputerChangeInfo()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.ComputerChangeInfo",
                TableControl.Create()
                    .AddHeader(Alignment.Left, label: "HasSucceeded", width: 12)
                    .AddHeader(label: "ComputerName", width: 25)
                    .StartRowDefinition()
                        .AddPropertyColumn("HasSucceeded")
                        .AddPropertyColumn("ComputerName")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_RenameComputerChangeInfo()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.RenameComputerChangeInfo",
                TableControl.Create()
                    .AddHeader(Alignment.Left, label: "HasSucceeded", width: 12)
                    .AddHeader(label: "OldComputerName", width: 25)
                    .AddHeader(label: "NewComputerName", width: 25)
                    .StartRowDefinition()
                        .AddPropertyColumn("HasSucceeded")
                        .AddPropertyColumn("OldComputerName")
                        .AddPropertyColumn("NewComputerName")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ModuleInfoGrouping(CustomControl[] sharedControls)
        {
            yield return new FormatViewDefinition("Module",
                TableControl.Create()
                    .GroupByScriptBlock("Split-Path -Parent $_.Path | ForEach-Object { if([Version]::TryParse((Split-Path $_ -Leaf), [ref]$null)) { Split-Path -Parent $_} else {$_} } | Split-Path -Parent", customControl: sharedControls[0])
                    .AddHeader(Alignment.Left, width: 10)
                    .AddHeader(Alignment.Left, width: 10)
                    .AddHeader(Alignment.Left, label: "PreRelease", width: 10)
                    .AddHeader(Alignment.Left, width: 35)
                    .AddHeader(Alignment.Left, width: 9, label: "PSEdition")
                    .AddHeader(Alignment.Left, label: "ExportedCommands")
                    .StartRowDefinition()
                        .AddPropertyColumn("ModuleType")
                        .AddPropertyColumn("Version")
                        .AddScriptBlockColumn(@"
                            if ($_.PrivateData -and $_.PrivateData.PSData)
                            {
                                    $_.PrivateData.PSData.PreRelease
                            }")
                        .AddPropertyColumn("Name")
                        .AddScriptBlockColumn(@"
                            $result = [System.Collections.ArrayList]::new()
                            $editions = $_.CompatiblePSEditions
                            if (-not $editions)
                            {
                                $editions = @('Desktop')
                            }

                            foreach ($edition in $editions)
                            {
                                $result += $edition.Substring(0,4)
                            }

                            ($result | Sort-Object) -join ','")
                        .AddScriptBlockColumn("$_.ExportedCommands.Keys")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSModuleInfo()
        {
            yield return new FormatViewDefinition("Module",
                TableControl.Create()
                    .AddHeader(Alignment.Left, width: 10)
                    .AddHeader(Alignment.Left, width: 10)
                    .AddHeader(Alignment.Left, label: "PreRelease", width: 10)
                    .AddHeader(Alignment.Left, width: 35)
                    .AddHeader(Alignment.Left, label: "ExportedCommands")
                    .StartRowDefinition()
                        .AddPropertyColumn("ModuleType")
                        .AddPropertyColumn("Version")
                        .AddScriptBlockColumn(@"
                            if ($_.PrivateData -and $_.PrivateData.PSData)
                            {
                                    $_.PrivateData.PSData.PreRelease
                            }")
                        .AddPropertyColumn("Name")
                        .AddScriptBlockColumn("$_.ExportedCommands.Keys")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("Module",
                WideControl.Create()
                    .AddPropertyEntry("Name")
                .EndWideControl());

            yield return new FormatViewDefinition("Module",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"Name")
                        .AddItemProperty(@"Path")
                        .AddItemProperty(@"Description")
                        .AddItemProperty(@"ModuleType")
                        .AddItemProperty(@"Version")
                        .AddItemScriptBlock(
                            @"
                            if ($_.PrivateData -and $_.PrivateData.PSData)
                            {
                                    $_.PrivateData.PSData.PreRelease
                            }",
                            label: "PreRelease")
                        .AddItemProperty(@"NestedModules")
                        .AddItemScriptBlock(@"$_.ExportedFunctions.Keys", label: "ExportedFunctions")
                        .AddItemScriptBlock(@"$_.ExportedCmdlets.Keys", label: "ExportedCmdlets")
                        .AddItemScriptBlock(@"$_.ExportedVariables.Keys", label: "ExportedVariables")
                        .AddItemScriptBlock(@"$_.ExportedAliases.Keys", label: "ExportedAliases")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ExperimentalFeature()
        {
            yield return new FormatViewDefinition("ExperimentalFeature",
                TableControl.Create()
                    .AddHeader(Alignment.Left, width: 35)
                    .AddHeader(Alignment.Right, width: 7)
                    .AddHeader(Alignment.Left, width: 35)
                    .AddHeader(Alignment.Left)
                    .StartRowDefinition()
                        .AddPropertyColumn("Name")
                        .AddPropertyColumn("Enabled")
                        .AddPropertyColumn("Source")
                        .AddPropertyColumn("Description")
                    .EndRowDefinition()
                .EndTable());

            yield return new FormatViewDefinition("ExperimentalFeature",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty("Name")
                        .AddItemProperty("Enabled")
                        .AddItemProperty("Source")
                        .AddItemProperty("Description")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_BasicHtmlWebResponseObject()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.BasicHtmlWebResponseObject",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"StatusCode")
                        .AddItemProperty(@"StatusDescription")
                        .AddItemScriptBlock(@"
                                  $result = $_.Content
                                  $result = $result.Substring(0, [Math]::Min($result.Length, 200) )
                                  if($result.Length -eq 200) { $result += ""`u{2026}"" }

                                  $result
                                ", label: "Content")
                        .AddItemScriptBlock(@"
                                  $result = $_.RawContent
                                  $result = $result.Substring(0, [Math]::Min($result.Length, 200) )
                                  if($result.Length -eq 200) { $result += ""`u{2026}"" }

                                  $result
                                ", label: "RawContent")
                        .AddItemProperty(@"Headers")
                        .AddItemProperty(@"Images")
                        .AddItemProperty(@"InputFields")
                        .AddItemProperty(@"Links")
                        .AddItemProperty(@"RawContentLength")
                        .AddItemProperty(@"RelationLink")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_WebResponseObject()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.WebResponseObject",
                ListControl.Create()
                    .StartEntry()
                        .AddItemProperty(@"StatusCode")
                        .AddItemProperty(@"StatusDescription")
                        .AddItemProperty(@"Content")
                        .AddItemScriptBlock(@"
                                  $result = $_.RawContent
                                  $result = $result.Substring(0, [Math]::Min($result.Length, 200) )
                                  if($result.Length -eq 200) { $result += ""`u{2026}"" }

                                  $result
                                ", label: "RawContent")
                        .AddItemProperty(@"Headers")
                        .AddItemProperty(@"RawContentLength")
                        .AddItemProperty(@"RelationLink")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Powershell_Utility_FileHashInfo()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.Commands.FileHashInfo",
                TableControl.Create()
                    .AddHeader(Alignment.Left, width: 15)
                    .AddHeader(Alignment.Left, width: 70)
                    .AddHeader()
                    .StartRowDefinition()
                        .AddPropertyColumn("Algorithm")
                        .AddPropertyColumn("Hash")
                        .AddPropertyColumn("Path")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_PSRunspaceDebug()
        {
            yield return new FormatViewDefinition("PSRunspaceDebug>",
                TableControl.Create()
                    .AddHeader(Alignment.Right, label: "Id", width: 3)
                    .AddHeader(Alignment.Left, label: "Name", width: 20)
                    .AddHeader(Alignment.Left, label: "Enabled", width: 10)
                    .AddHeader(Alignment.Left, label: "BreakAll", width: 10)
                    .StartRowDefinition()
                        .AddPropertyColumn("RunspaceId")
                        .AddPropertyColumn("RunspaceName")
                        .AddPropertyColumn("Enabled")
                        .AddPropertyColumn("BreakAll")
                    .EndRowDefinition()
                .EndTable());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_MarkdownRender_MarkdownOptionInfo()
        {
            yield return new FormatViewDefinition("Microsoft.PowerShell.MarkdownRender.PSMarkdownOptionInfo",
                ListControl.Create()
                    .StartEntry()
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Header1')", label: "Header1")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Header2')", label: "Header2")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Header3')", label: "Header3")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Header4')", label: "Header4")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Header5')", label: "Header5")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Header6')", label: "Header6")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Code')", label: "Code")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Link')", label: "Link")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('Image')", label: "Image")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('EmphasisBold')", label: "EmphasisBold")
                        .AddItemScriptBlock(@"$_.AsEscapeSequence('EmphasisItalics')", label: "EmphasisItalics")
                    .EndEntry()
                .EndList());
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ByteCollection()
        {
            yield return new FormatViewDefinition(
                "Microsoft.PowerShell.Commands.ByteCollection",
                TableControl.Create()
                    .AddHeader(Alignment.Right, label: "Offset", width: 16)
                    .AddHeader(Alignment.Left, label: "Bytes\n00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F", width: 47)
                    .AddHeader(Alignment.Left, label: "Ascii", width: 16)
                    .StartRowDefinition()
                        .AddPropertyColumn("HexOffset")
                        .AddPropertyColumn("HexBytes")
                        .AddPropertyColumn("Ascii")
                    .EndRowDefinition()
                    .GroupByProperty("Label")
                .EndTable());
        }
    }
}
