﻿#pragma checksum "..\..\..\Pages\editarprod.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0A62E91C041FF225ABFEE57680EFF4F88C9C1D521331F1BB7E387AFBE212148"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InventarioAlmacen.Pages;
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


namespace InventarioAlmacen.Pages {
    
    
    /// <summary>
    /// editarprod
    /// </summary>
    public partial class editarprod : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\editarprod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\editarprod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCodigoProducto;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\editarprod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreProducto;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\editarprod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidadProducto;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Pages\editarprod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcionProducto;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Pages\editarprod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioProducto;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Pages\editarprod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProductoMarca;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Pages\editarprod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardarProducto;
        
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
            System.Uri resourceLocater = new System.Uri("/InventarioAlmacen;component/pages/editarprod.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\editarprod.xaml"
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
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\editarprod.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCodigoProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtNombreProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtCantidadProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtDescripcionProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPrecioProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtProductoMarca = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.btnGuardarProducto = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\Pages\editarprod.xaml"
            this.btnGuardarProducto.Click += new System.Windows.RoutedEventHandler(this.btnGuardarProducto_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

