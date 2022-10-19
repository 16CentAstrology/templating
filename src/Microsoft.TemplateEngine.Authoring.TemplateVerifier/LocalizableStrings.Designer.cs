﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.TemplateEngine.Authoring.TemplateVerifier {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizableStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizableStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.TemplateEngine.Authoring.TemplateVerifier.LocalizableStrings", typeof(LocalizableStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template installation expected to pass but it had exit code &apos;{0}&apos;..
        /// </summary>
        internal static string VerificationEngine_Error_InstallUnexpectedFail {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_InstallUnexpectedFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File extension passed to scrubber should not start with dot..
        /// </summary>
        internal static string VerificationEngine_Error_ScrubberExtension {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_ScrubberExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder [{0}] should not exist in the template output - cannot verify stdout/stderr in such case..
        /// </summary>
        internal static string VerificationEngine_Error_StdOutFolderExists {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_StdOutFolderExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template name is mandatory, but was not supplied..
        /// </summary>
        internal static string VerificationEngine_Error_TemplateNameMandatory {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_TemplateNameMandatory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected error encountered..
        /// </summary>
        internal static string VerificationEngine_Error_Unexpected {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_Unexpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template instantiation expected to pass but it had exit code &apos;{0}&apos;..
        /// </summary>
        internal static string VerificationEngine_Error_UnexpectedFail {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_UnexpectedFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template instantiation expected to fail but it passed..
        /// </summary>
        internal static string VerificationEngine_Error_UnexpectedPass {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_UnexpectedPass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template instantiation expected not to have any stderr output, but stderr output was encountered:{0}{1}.
        /// </summary>
        internal static string VerificationEngine_Error_UnexpectedStdErr {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_UnexpectedStdErr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The working directory already exists and is not empty..
        /// </summary>
        internal static string VerificationEngine_Error_WorkDirExists {
            get {
                return ResourceManager.GetString("VerificationEngine_Error_WorkDirExists", resourceCulture);
            }
        }
    }
}