using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.UI;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Bootstrap.A11y")]
[assembly: AssemblyDescription("Twitter Bootstrap Controls for ASP.NET WebForms")]
[assembly: AssemblyCompany("Kinsey Roberts and Pedro Fernandes")]
[assembly: AssemblyProduct("Bootstrap.A11y")]
[assembly: AssemblyCopyright("Copyright © 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyConfiguration("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
[assembly: TagPrefix("Bootstrap.A11y", "twt")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("adf25736-b9f7-418d-bedd-efd822b45122")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.1.0.0")]
[assembly: AssemblyFileVersion("1.1.0.0")]

// web resource attributes for bootstrap accessibility
[assembly: WebResource(Bootstrap.A11y.AccessibleWebControl.PayPalCssResourceName, Bootstrap.A11y.AccessibleWebControl.CssMimeType)]
[assembly: WebResource(Bootstrap.A11y.AccessibleWebControl.PayPalJsResourceName, Bootstrap.A11y.AccessibleWebControl.JsMimeType)]
[assembly: WebResource(Bootstrap.A11y.AccessibleWebControl.JonGundCssResourceName, Bootstrap.A11y.AccessibleWebControl.CssMimeType)]
[assembly: WebResource(Bootstrap.A11y.AccessibleWebControl.JonGundJsResourceName, Bootstrap.A11y.AccessibleWebControl.JsMimeType)]
