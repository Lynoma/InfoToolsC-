#pragma checksum "..\..\..\Vues\ViewFacture - Copier.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7AA7FD881648CACC512DE2ADBDC3E150C46D4E80EB7438B92ECEFF8D1E0E7A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetInfoToolsCRM;
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


namespace ProjetInfoToolsCRM {
    
    
    /// <summary>
    /// ViewFacture
    /// </summary>
    public partial class ViewFacture : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Vues\ViewFacture - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewFactures;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Vues\ViewFacture - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView ClientsGrid;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Vues\ViewFacture - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtID;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Vues\ViewFacture - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboC;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Vues\ViewFacture - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboP;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Vues\ViewFacture - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFactureAdd;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Vues\ViewFacture - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFactureUpdate;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Vues\ViewFacture - Copier.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnFactureDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetInfoToolsCRM;component/vues/viewfacture%20-%20copier.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vues\ViewFacture - Copier.xaml"
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
            this.ListViewFactures = ((System.Windows.Controls.ListView)(target));
            
            #line 15 "..\..\..\Vues\ViewFacture - Copier.xaml"
            this.ListViewFactures.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Facture_selectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ClientsGrid = ((System.Windows.Controls.GridView)(target));
            return;
            case 3:
            this.TxtID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CboC = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.CboP = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.BtnFactureAdd = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\Vues\ViewFacture - Copier.xaml"
            this.BtnFactureAdd.Click += new System.Windows.RoutedEventHandler(this.BtnFactureAdd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnFactureUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\Vues\ViewFacture - Copier.xaml"
            this.BtnFactureUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnFactureUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnFactureDelete = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Vues\ViewFacture - Copier.xaml"
            this.BtnFactureDelete.Click += new System.Windows.RoutedEventHandler(this.BtnFactureDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

