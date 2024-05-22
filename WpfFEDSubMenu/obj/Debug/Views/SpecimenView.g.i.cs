﻿#pragma checksum "..\..\..\Views\SpecimenView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "920B423EB0DD87434C9E084A6B741A3A251D56F2BD5AAE77E50BD79280FED098"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Themes;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WpfFEDSubMenu.Components;
using WpfFEDSubMenu.Helper;
using WpfFEDSubMenu.ViewModel;
using WpfFEDSubMenu.Views;


namespace WpfFEDSubMenu.Views {
    
    
    /// <summary>
    /// SpecimenView
    /// </summary>
    public partial class SpecimenView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 271 "..\..\..\Views\SpecimenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSpecimen;
        
        #line default
        #line hidden
        
        
        #line 340 "..\..\..\Views\SpecimenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSpecimenName;
        
        #line default
        #line hidden
        
        
        #line 421 "..\..\..\Views\SpecimenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScrollLeftButton;
        
        #line default
        #line hidden
        
        
        #line 422 "..\..\..\Views\SpecimenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScrollRightButton;
        
        #line default
        #line hidden
        
        
        #line 423 "..\..\..\Views\SpecimenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl MainTabControl;
        
        #line default
        #line hidden
        
        
        #line 509 "..\..\..\Views\SpecimenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MyFrame;
        
        #line default
        #line hidden
        
        
        #line 532 "..\..\..\Views\SpecimenView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MyFrame2;
        
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
            System.Uri resourceLocater = new System.Uri("/FED_DOT_NET;component/views/specimenview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SpecimenView.xaml"
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
            this.cmbSpecimen = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.tbSpecimenName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 401 "..\..\..\Views\SpecimenView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ScrollLeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 421 "..\..\..\Views\SpecimenView.xaml"
            this.ScrollLeftButton.Click += new System.Windows.RoutedEventHandler(this.ScrollLeftButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ScrollRightButton = ((System.Windows.Controls.Button)(target));
            
            #line 422 "..\..\..\Views\SpecimenView.xaml"
            this.ScrollRightButton.Click += new System.Windows.RoutedEventHandler(this.ScrollRightButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainTabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 7:
            this.MyFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 8:
            
            #line 517 "..\..\..\Views\SpecimenView.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.StackPanel_MouseUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MyFrame2 = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

