﻿#pragma checksum "C:\Users\Shinelon\Desktop\期中项目\uwpMiddleProject\uwpMiddleProject\NewPage7.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FDF5FF55747F5E7BB40C54F07B4AF6DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uwpMiddleProject
{
    partial class NewPage7 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.group1 = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.width1000 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.width800 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.stackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.confirm = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 59 "..\..\..\NewPage7.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.confirm).Click += this.confirmButtonClick;
                    #line default
                }
                break;
            case 6:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.textProblem = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.trueAnswer = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.falseAnswer = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.answerD = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 50 "..\..\..\NewPage7.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.answerD).Click += this.answerDClick;
                    #line default
                }
                break;
            case 11:
                {
                    this.answerC = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 46 "..\..\..\NewPage7.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.answerC).Click += this.answerCClick;
                    #line default
                }
                break;
            case 12:
                {
                    this.answerB = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 42 "..\..\..\NewPage7.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.answerB).Click += this.answerBClick;
                    #line default
                }
                break;
            case 13:
                {
                    this.answerA = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 38 "..\..\..\NewPage7.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.answerA).Click += this.answerAClick;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

