#pragma checksum "..\..\..\Vues\ViewLigneFacture.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75E47CA82F6AF79E4CA7B26FA27138F23C85730F3030E49A4E461D37C537BAA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetInfoToolsCRM.Vues;
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


namespace ProjetInfoToolsCRM.Vues {
    
    
    /// <summary>
    /// ViewLigneFacture
    /// </summary>
    public partial class ViewLigneFacture : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Vues\ViewLigneFacture.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewLF;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Vues\ViewLigneFacture.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView ClientsGrid;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Vues\ViewLigneFacture.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtQte;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Vues\ViewLigneFacture.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboF;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Vues\ViewLigneFacture.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboP;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\Vues\ViewLigneFacture.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLFAdd;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Vues\ViewLigneFacture.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLFUpdate;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Vues\ViewLigneFacture.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLFDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetInfoToolsCRM;component/vues/viewlignefacture.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vues\ViewLigneFacture.xaml"
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
            this.ListViewLF = ((System.Windows.Controls.ListView)(target));
            
            #line 21 "..\..\..\Vues\ViewLigneFacture.xaml"
            this.ListViewLF.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListViewLF_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ClientsGrid = ((System.Windows.Controls.GridView)(target));
            return;
            case 3:
            this.TxtQte = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CboF = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.CboP = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.BtnLFAdd = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\Vues\ViewLigneFacture.xaml"
            this.BtnLFAdd.Click += new System.Windows.RoutedEventHandler(this.BtnLFAdd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnLFUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Vues\ViewLigneFacture.xaml"
            this.BtnLFUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnLFUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnLFDelete = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\Vues\ViewLigneFacture.xaml"
            this.BtnLFDelete.Click += new System.Windows.RoutedEventHandler(this.BtnLFDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

