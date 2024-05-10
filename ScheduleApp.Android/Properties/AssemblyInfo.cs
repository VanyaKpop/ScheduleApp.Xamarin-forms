using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;
using Xamarin.Forms;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ScheduleApp.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ScheduleApp.Android")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Add some fonts
[assembly: ExportFont("Nunito-VariableFont_wght.ttf", Alias = "Nunito")]
[assembly: ExportFont("Nunito-Black.ttf", Alias = "NunitoBlack")]
[assembly: ExportFont("Nunito-Bold.ttf", Alias = "NunitoBold")]
[assembly: ExportFont("Nunito-ExtraBold.ttf", Alias = "NunitoExtra")]
[assembly: ExportFont("Nunito-SemiBold.ttf", Alias = "NunitoSemi")]
[assembly: ExportFont("Nunito-Medium.ttf", Alias = "NunitoMedium")]
[assembly: ExportFont("Nunito-MediumItalic.ttf", Alias = "NunitoMediumItalic")]
[assembly: ExportFont("Nunito-Regular.ttf", Alias = "NunitoRegular")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
