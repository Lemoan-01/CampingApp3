﻿#pragma checksum "..\..\..\..\..\Views\UserControls\Admin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5E5CD8603D379EDEAD426B3232A3B8D12AB1B7C5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CampingApp3.ViewModels;
using CampingApp3.Views.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CampingApp3.Views.UserControls {
    
    
    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPID;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbPID;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPrice;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbPrice;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrice;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBlock;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBlock;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EndDatePicker;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StartDatePicker;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblDates;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\Views\UserControls\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CampingApp3;component/views/usercontrols/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblPID = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtbPID = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.txtbPID.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.clearPlaceholder_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.txtbPID.LostFocus += new System.Windows.RoutedEventHandler(this.resetPlaceholder_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtbPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.txtbPrice.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.clearPlaceholder_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.txtbPrice.LostFocus += new System.Windows.RoutedEventHandler(this.resetPlaceholder_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnPrice = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.btnPrice.TouchEnter += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.btnUpdate_Price_Click);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.btnPrice.Click += new System.Windows.RoutedEventHandler(this.btnUpdate_Price_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblBlock = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtBlock = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.txtBlock.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.clearPlaceholder_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 32 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.txtBlock.LostFocus += new System.Windows.RoutedEventHandler(this.resetPlaceholder_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EndDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.StartDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.lblDates = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.btnBlock = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\..\Views\UserControls\Admin.xaml"
            this.btnBlock.Click += new System.Windows.RoutedEventHandler(this.btnBlock_Place);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

