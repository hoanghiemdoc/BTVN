#pragma checksum "D:\ky3-c#\T2010A-C#\BTVN-C#\BTVN\FormDemo\Mail.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "597358CA40A8A494B4F4EFBBBF590934E43AF525FFB119773849D06E7E036B2B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTVN.FormDemo
{
    partial class Mail : 
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
            case 2: // FormDemo\Mail.xaml line 17
                {
                    this.MainFarm = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // FormDemo\Mail.xaml line 30
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // FormDemo\Mail.xaml line 31
                {
                    this.txtContentEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // FormDemo\Mail.xaml line 32
                {
                    this.txtContent = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // FormDemo\Mail.xaml line 19
                {
                    this.inputEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // FormDemo\Mail.xaml line 20
                {
                    this.inputContentEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // FormDemo\Mail.xaml line 21
                {
                    this.inputContent = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // FormDemo\Mail.xaml line 22
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.Button_Click;
                }
                break;
            case 10: // FormDemo\Mail.xaml line 23
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Button_Back;
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

