﻿#pragma checksum "..\..\..\..\Views\MakeReservationPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1359051B92528DFECBB187DA45D9DF4E9BA28849"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CampingApp3.Views;
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


namespace CampingApp3.Views {
    
    
    /// <summary>
    /// MakeReservationPage
    /// </summary>
    public partial class MakeReservationPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Views\MakeReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainWindowGrid;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Views\MakeReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel pnlTopBar;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Views\MakeReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Views\MakeReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTerminate;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\MakeReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox aantPersonen;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Views\MakeReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\MakeReservationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pay;
        
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
            System.Uri resourceLocater = new System.Uri("/CampingApp3;component/views/makereservationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\MakeReservationPage.xaml"
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
            this.MainWindowGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.pnlTopBar = ((System.Windows.Controls.StackPanel)(target));
            
            #line 13 "..\..\..\..\Views\MakeReservationPage.xaml"
            this.pnlTopBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.pnlTopBar_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Views\MakeReservationPage.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnTerminate = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Views\MakeReservationPage.xaml"
            this.btnTerminate.Click += new System.Windows.RoutedEventHandler(this.btnTerminate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.aantPersonen = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Views\MakeReservationPage.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Pay = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Views\MakeReservationPage.xaml"
            this.Pay.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

