#pragma checksum "..\..\Register.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6BF4F54BC00982B07143E801C3F50A19DA82B3C56E8D839B7F302459D602697D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using Organized;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Organized {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 99 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameTextBox;
        
        #line default
        #line hidden
        
        
        #line 258 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 318 "..\..\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Organized;component/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Register.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\Register.xaml"
            ((Organized.Register)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Register_Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 77 "..\..\Register.xaml"
            ((MahApps.Metro.IconPacks.PackIconMaterial)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimize_WIndow_Icon_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 87 "..\..\Register.xaml"
            ((MahApps.Metro.IconPacks.PackIconMaterial)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Close_WIndow_Icon_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FirstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.LastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.UsernameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            
            #line 338 "..\..\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Return_To_Login_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 345 "..\..\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Register_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

