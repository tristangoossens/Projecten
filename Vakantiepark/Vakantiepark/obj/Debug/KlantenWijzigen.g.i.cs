﻿#pragma checksum "..\..\KlantenWijzigen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055C078DB9895C7B3C420FA478F1AB30284A4D8D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Vakantiepark;


namespace Vakantiepark {
    
    
    /// <summary>
    /// KlantenWijzigen
    /// </summary>
    public partial class KlantenWijzigen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWijzig;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVoornaam;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAchternaam;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpGeboortedatum;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefoon;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWoonplaats;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVerwijder;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\KlantenWijzigen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbID;
        
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
            System.Uri resourceLocater = new System.Uri("/Vakantiepark;component/klantenwijzigen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KlantenWijzigen.xaml"
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
            
            #line 8 "..\..\KlantenWijzigen.xaml"
            ((Vakantiepark.KlantenWijzigen)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnWijzig = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\KlantenWijzigen.xaml"
            this.btnWijzig.Click += new System.Windows.RoutedEventHandler(this.btnWijzig_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtVoornaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtAchternaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dpGeboortedatum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.txtTelefoon = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtWoonplaats = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnVerwijder = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\KlantenWijzigen.xaml"
            this.btnVerwijder.Click += new System.Windows.RoutedEventHandler(this.btnVerwijder_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lbID = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

