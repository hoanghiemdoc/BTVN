﻿#pragma checksum "D:\ky3-c#\T2010A-C#\BTVN-C#\BTVN\Session1\BT1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A6E055F4C249E862355D0CC954526C78D6593F90814834C3CC2E10790667AE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTVN.Session1
{
    partial class BT1 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Session1\BT1.xaml line 26
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Session1\BT1.xaml line 27
                {
                    this.txtContentEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Session1\BT1.xaml line 28
                {
                    this.txtContent = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // Session1\BT1.xaml line 18
                {
                    this.inputEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Session1\BT1.xaml line 19
                {
                    this.inputContentEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Session1\BT1.xaml line 20
                {
                    this.inputContent = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Session1\BT1.xaml line 21
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.Button_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
