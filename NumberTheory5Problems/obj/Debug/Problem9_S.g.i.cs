﻿#pragma checksum "..\..\Problem9_S.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0149CEA63506658BF3E77175E1531E997239847B2FA91F04DE9F784229DC346"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NumberTheory5Problems;
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


namespace NumberTheory5Problems {
    
    
    /// <summary>
    /// Problem9_S
    /// </summary>
    public partial class Problem9_S : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Problem9_S.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Textbox_Output;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Problem9_S.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_a;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Problem9_S.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Next;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Problem9_S.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_p;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Problem9_S.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_n;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Problem9_S.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_n_Copy;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Problem9_S.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Next1;
        
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
            System.Uri resourceLocater = new System.Uri("/NumberTheory5Problems;component/problem9_s.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Problem9_S.xaml"
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
            this.Textbox_Output = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Textbox_a = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Button_Next = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Problem9_S.xaml"
            this.Button_Next.Click += new System.Windows.RoutedEventHandler(this.Button_Next_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Textbox_p = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Label_n = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Label_n_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Button_Next1 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Problem9_S.xaml"
            this.Button_Next1.Click += new System.Windows.RoutedEventHandler(this.Button_Next1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

