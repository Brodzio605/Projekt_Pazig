﻿#pragma checksum "..\..\..\Views\BadaniaOkno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B923CD4FE27F8C9B7DED6A0EBB934694C24FFDE41F7F342D4F3C142224337D4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using BadanieKrwi;
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


namespace BadanieKrwi.Views {
    
    
    /// <summary>
    /// BadaniaOkno
    /// </summary>
    public partial class BadaniaOkno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 373 "..\..\..\Views\BadaniaOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button wroc;
        
        #line default
        #line hidden
        
        
        #line 385 "..\..\..\Views\BadaniaOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button edytuj;
        
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
            System.Uri resourceLocater = new System.Uri("/BadanieKrwi;component/views/badaniaokno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\BadaniaOkno.xaml"
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
            this.wroc = ((System.Windows.Controls.Button)(target));
            
            #line 379 "..\..\..\Views\BadaniaOkno.xaml"
            this.wroc.Click += new System.Windows.RoutedEventHandler(this.WrocMenu);
            
            #line default
            #line hidden
            return;
            case 2:
            this.edytuj = ((System.Windows.Controls.Button)(target));
            
            #line 391 "..\..\..\Views\BadaniaOkno.xaml"
            this.edytuj.Click += new System.Windows.RoutedEventHandler(this.Edytuj);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

