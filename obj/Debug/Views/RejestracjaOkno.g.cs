﻿#pragma checksum "..\..\..\Views\RejestracjaOkno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "750F3A6EFE39A7147E146B8182652D11A2976BAB36677C6DA4C066F2F342F0DE"
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
using BadanieKrwi.ViewModels;
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
    /// RejestracjaOkno
    /// </summary>
    public partial class RejestracjaOkno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Views\RejestracjaOkno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BadanieKrwi.Views.RejestracjaOkno rejestracja;
        
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
            System.Uri resourceLocater = new System.Uri("/BadanieKrwi;component/views/rejestracjaokno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\RejestracjaOkno.xaml"
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
            this.rejestracja = ((BadanieKrwi.Views.RejestracjaOkno)(target));
            return;
            case 2:
            
            #line 99 "..\..\..\Views\RejestracjaOkno.xaml"
            ((System.Windows.Controls.PasswordBox)(target)).PasswordChanged += new System.Windows.RoutedEventHandler(this.inputHaslo_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 111 "..\..\..\Views\RejestracjaOkno.xaml"
            ((System.Windows.Controls.PasswordBox)(target)).PasswordChanged += new System.Windows.RoutedEventHandler(this.inputPowHaslo_PasswordChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

