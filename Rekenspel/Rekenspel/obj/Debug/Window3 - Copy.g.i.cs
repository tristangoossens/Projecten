﻿#pragma checksum "..\..\Window3 - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F0D0275E249A195D0DCBAA8FA5749DE792145425"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Rekenspel;
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


namespace Rekenspel {
    
    
    /// <summary>
    /// Window3
    /// </summary>
    public partial class Window3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\Window3 - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid imgKeer;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Window3 - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKeerTerug;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Window3 - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbGetal1;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Window3 - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbGetal2;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window3 - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtKeerAntwoord;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window3 - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKeerVerstuur;
        
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
            System.Uri resourceLocater = new System.Uri("/Rekenspel;component/window3%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window3 - Copy.xaml"
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
            this.imgKeer = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btnKeerTerug = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Window3 - Copy.xaml"
            this.btnKeerTerug.Click += new System.Windows.RoutedEventHandler(this.btnKeerTerug_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbGetal1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbGetal2 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtKeerAntwoord = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnKeerVerstuur = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Window3 - Copy.xaml"
            this.btnKeerVerstuur.Click += new System.Windows.RoutedEventHandler(this.btnKeerVerstuur_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

