﻿#pragma checksum "..\..\..\Prodotti.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DB00CDDDF3983646E0A535F8FE32E0B3CE879F7C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Esercitazione05_27_03_2024;
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


namespace Esercitazione05_27_03_2024 {
    
    
    /// <summary>
    /// Prodotti
    /// </summary>
    public partial class Prodotti : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Prodotti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Home;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Prodotti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Utenti;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Prodotti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Categorie;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Prodotti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Variazioni;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Prodotti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Prezzi;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Prodotti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ordini;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Esercitazione05_27-03-2024;component/prodotti.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Prodotti.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Home = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Prodotti.xaml"
            this.Home.Click += new System.Windows.RoutedEventHandler(this.Home_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Utenti = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Prodotti.xaml"
            this.Utenti.Click += new System.Windows.RoutedEventHandler(this.Utenti_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Categorie = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Prodotti.xaml"
            this.Categorie.Click += new System.Windows.RoutedEventHandler(this.Categorie_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Variazioni = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Prodotti.xaml"
            this.Variazioni.Click += new System.Windows.RoutedEventHandler(this.Variazioni_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Prezzi = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Prodotti.xaml"
            this.Prezzi.Click += new System.Windows.RoutedEventHandler(this.Prezzi_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Ordini = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Prodotti.xaml"
            this.Ordini.Click += new System.Windows.RoutedEventHandler(this.Ordini_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

