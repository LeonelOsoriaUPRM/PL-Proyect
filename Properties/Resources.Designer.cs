﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BabyCsharpProject.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BabyCsharpProject.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace LearningSpace
        ///{
        ///	static class Program
        ///	{
        ///		static void Main(string[] args)
        ///		{
        ///			Console.WriteLine(&quot;Give me an integer&quot;);
        ///			int a = Convert.ToInt32(Console.ReadLine());
        ///			Console.WriteLine(&quot;Give me another integer&quot;);
        ///			int b = Convert.ToInt32(Console.ReadLine());
        ///			int c = a+b;
        ///			Console.WriteLine(&quot;The sum of those integers is:&quot;+c);
        ///			Console.ReadLine();
        ///		}
        ///	}
        ///}.
        /// </summary>
        internal static string a_b_Text {
            get {
                return ResourceManager.GetString("a+b.Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace LearningSpace
        ///{
        ///	static class Program
        ///	{
        ///		static void Main(string[] args)
        ///		{
        ///			Console.WriteLine(&quot;Hello World&quot;);
        ///			Console.ReadLine();
        ///		}
        ///	}
        ///}.
        /// </summary>
        internal static string HelloWorld_Text {
            get {
                return ResourceManager.GetString("HelloWorld.Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace LearningSpace
        ///{
        ///	static class Program
        ///	{
        ///		static void Main(string[] args)
        ///		{
        ///Console.WriteLine(&quot;Enter option desired: \n	0, \n	1,\n	 2\n&quot;);
        ///	int number = Convert.ToInt32(Console.Read());
        ///	Switch(number)
        ///	{
        ///		case 0
        ///			Console.WriteLine(&quot;General Kenobi...&quot;);
        ///			break;
        ///		case 1
        ///			Console.WriteLine(&quot;Hi there what can I do for you?&quot;);	
        ///			break;
        ///		case 2
        ///			Console.WriteLine(&quot;So... How have you been?&quot;);
        ///			break;
        ///		default
        ///			Console.WiriteLine(&quot;Don&apos;t know what  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Kenobi {
            get {
                return ResourceManager.GetString("Kenobi", resourceCulture);
            }
        }
    }
}
