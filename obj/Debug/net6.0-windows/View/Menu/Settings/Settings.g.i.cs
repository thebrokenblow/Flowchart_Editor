﻿#pragma checksum "..\..\..\..\..\..\View\Menu\Settings\Settings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E399F3FC3AED2440683A7543B9FCD83181384B95"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Flowchart_Editor {
    
    
    /// <summary>
    /// Settings
    /// </summary>
    public partial class Settings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\..\View\Menu\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxLineEntry;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\View\Menu\Settings\Settings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBoxOriginLine;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Flowchart_Editor;V1.0.0.0;component/view/menu/settings/settings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\View\Menu\Settings\Settings.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.checkBoxLineEntry = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\..\..\..\..\View\Menu\Settings\Settings.xaml"
            this.checkBoxLineEntry.Checked += new System.Windows.RoutedEventHandler(this.CheckedLineEntry);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\..\..\View\Menu\Settings\Settings.xaml"
            this.checkBoxLineEntry.Unchecked += new System.Windows.RoutedEventHandler(this.CheckedLineEntry);
            
            #line default
            #line hidden
            return;
            case 2:
            this.checkBoxOriginLine = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\..\..\..\..\View\Menu\Settings\Settings.xaml"
            this.checkBoxOriginLine.Checked += new System.Windows.RoutedEventHandler(this.CheckedOriginLine);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\..\..\..\View\Menu\Settings\Settings.xaml"
            this.checkBoxOriginLine.Unchecked += new System.Windows.RoutedEventHandler(this.CheckedOriginLine);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
