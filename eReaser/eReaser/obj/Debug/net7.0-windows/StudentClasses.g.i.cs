// Updated by XamlIntelliSenseFileGenerator 2023. 11. 14. 20:08:25
#pragma checksum "..\..\..\StudentClasses.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A1415E9F61CD3D12FE27A6BFA6E3A6F77BB4F97A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using eReaser;


namespace eReaser
{


    /// <summary>
    /// StudentClasses
    /// </summary>
    public partial class StudentGrades : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\..\StudentClasses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grd_Vertical;

#line default
#line hidden


#line 13 "..\..\..\StudentClasses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label button_TimeTable;

#line default
#line hidden


#line 21 "..\..\..\StudentClasses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label button_Logout;

#line default
#line hidden


#line 29 "..\..\..\StudentClasses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label button_logoutClose;

#line default
#line hidden


#line 36 "..\..\..\StudentClasses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grd_Horizontal;

#line default
#line hidden


#line 75 "..\..\..\StudentClasses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Subject;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/eReaser;V1.0.0.0;component/studentclasses.xaml", System.UriKind.Relative);

#line 1 "..\..\..\StudentClasses.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.grd_Vertical = ((System.Windows.Controls.Grid)(target));
                    return;
                case 2:
                    this.button_TimeTable = ((System.Windows.Controls.Label)(target));

#line 13 "..\..\..\StudentClasses.xaml"
                    this.button_TimeTable.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.button_TimeTable_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.button_Logout = ((System.Windows.Controls.Label)(target));

#line 21 "..\..\..\StudentClasses.xaml"
                    this.button_Logout.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.button_Logout_MouseDown);

#line default
#line hidden
                    return;
                case 4:
                    this.button_logoutClose = ((System.Windows.Controls.Label)(target));

#line 29 "..\..\..\StudentClasses.xaml"
                    this.button_logoutClose.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.button_logoutClose_MouseDown);

#line default
#line hidden
                    return;
                case 5:
                    this.grd_Horizontal = ((System.Windows.Controls.Grid)(target));
                    return;
                case 6:
                    this.grd_Container = ((System.Windows.Controls.Grid)(target));
                    return;
                case 7:
                    this.grd_0 = ((System.Windows.Controls.Grid)(target));

#line 50 "..\..\..\StudentClasses.xaml"
                    this.grd_0.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grd_MouseDown);

#line default
#line hidden
                    return;
                case 8:
                    this.grd_1 = ((System.Windows.Controls.Grid)(target));

#line 53 "..\..\..\StudentClasses.xaml"
                    this.grd_1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grd_MouseDown);

#line default
#line hidden
                    return;
                case 9:
                    this.grd_2 = ((System.Windows.Controls.Grid)(target));

#line 56 "..\..\..\StudentClasses.xaml"
                    this.grd_2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grd_MouseDown);

#line default
#line hidden
                    return;
                case 10:
                    this.grd_3 = ((System.Windows.Controls.Grid)(target));

#line 59 "..\..\..\StudentClasses.xaml"
                    this.grd_3.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grd_MouseDown);

#line default
#line hidden
                    return;
                case 11:
                    this.grd_4 = ((System.Windows.Controls.Grid)(target));

#line 62 "..\..\..\StudentClasses.xaml"
                    this.grd_4.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grd_MouseDown);

#line default
#line hidden
                    return;
                case 12:
                    this.grd_5 = ((System.Windows.Controls.Grid)(target));

#line 65 "..\..\..\StudentClasses.xaml"
                    this.grd_5.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grd_MouseDown);

#line default
#line hidden
                    return;
                case 13:
                    this.grd_6 = ((System.Windows.Controls.Grid)(target));

#line 68 "..\..\..\StudentClasses.xaml"
                    this.grd_6.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grd_MouseDown);

#line default
#line hidden
                    return;
                case 14:
                    this.grd_7 = ((System.Windows.Controls.Grid)(target));

#line 71 "..\..\..\StudentClasses.xaml"
                    this.grd_7.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.grd_MouseDown);

#line default
#line hidden
                    return;
                case 15:
                    this.lbl_Subject = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Grid grd_Main;
        internal System.Windows.Controls.Grid grd_Grades;
        internal System.Windows.Controls.Grid Info;
        internal System.Windows.Controls.Grid grd_Teacher;
        internal System.Windows.Controls.Label lbl_Teacher;
        internal System.Windows.Controls.Grid grd_Teacher_Copy;
        internal System.Windows.Controls.Grid grd_Teacher_Copy1;
        internal System.Windows.Controls.Label button_Classes;
        internal System.Windows.Controls.Label lbl_Teacher_Copy;
        internal System.Windows.Controls.Label lbl_Teacher_Copy1;
        internal System.Windows.Controls.Label lbl_Teacher_Copy2;
    }
}

