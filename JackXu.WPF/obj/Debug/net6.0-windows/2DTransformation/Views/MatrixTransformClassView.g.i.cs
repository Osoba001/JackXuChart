﻿#pragma checksum "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E213A1D4191E623127039415A3EF8ADEC557310E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using JackXu.WPF._2DTransformation.Views;
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


namespace JackXu.WPF._2DTransformation.Views {
    
    
    /// <summary>
    /// MatrixTransformClassView
    /// </summary>
    public partial class MatrixTransformClassView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbM11;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbM12;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbM21;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbM22;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOffsetX;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOffsetY;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas1;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.MatrixTransform matrixTransform;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/JackXu.WPF;component/2dtransformation/views/matrixtransformclassview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbM11 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbM12 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbM21 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbM22 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbOffsetX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbOffsetY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 62 "..\..\..\..\..\2DTransformation\Views\MatrixTransformClassView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnApply_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.canvas1 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 9:
            this.matrixTransform = ((System.Windows.Media.MatrixTransform)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

