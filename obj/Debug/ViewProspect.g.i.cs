#pragma checksum "..\..\ViewProspect.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "54E6244C03AB6B20BFD91C793245B75B2FDFCDF8C84E19918F069BC84FFEFE46"
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
    /// ViewProspect
    /// </summary>
    public partial class ViewProspect : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewProspects;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridView ClientsGrid;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtID;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNom;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtPrenom;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtAdresse;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtTelephone;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProspectAdd;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProspectUpdate;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\ViewProspect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnProspectDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetInfoToolsCRM;component/viewprospect.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewProspect.xaml"
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
            this.ListViewProspects = ((System.Windows.Controls.ListView)(target));
            
            #line 15 "..\..\ViewProspect.xaml"
            this.ListViewProspects.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Prospect_selectionChanged);
            
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
            this.TxtNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxtPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxtAdresse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TxtTelephone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.BtnProspectAdd = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\ViewProspect.xaml"
            this.BtnProspectAdd.Click += new System.Windows.RoutedEventHandler(this.BtnProspectAdd_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnProspectUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\ViewProspect.xaml"
            this.BtnProspectUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnProspectUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnProspectDelete = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\ViewProspect.xaml"
            this.BtnProspectDelete.Click += new System.Windows.RoutedEventHandler(this.BtnProspectDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

