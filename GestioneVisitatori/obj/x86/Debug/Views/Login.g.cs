﻿#pragma checksum "C:\Users\AlessandroAismondo\OneDrive - ITS Angelo Rizzoli\Desktop\SCUOLA\UFS\UFS15_SpringBoot\CODE\GestioneVisitatori\GestioneVisitatori\Views\Login.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E2E3649BFB7BDA22AB6C1A48A65B758D2D4A292653AC92996F969A0D34E057ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestioneVisitatori.Views
{
    partial class Login : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\Login.xaml line 31
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.LoginButton_Click;
                }
                break;
            case 3: // Views\Login.xaml line 40
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.BackToHome_Click;
                }
                break;
            case 4: // Views\Login.xaml line 36
                {
                    global::Windows.UI.Xaml.Documents.Hyperlink element4 = (global::Windows.UI.Xaml.Documents.Hyperlink)(target);
                    ((global::Windows.UI.Xaml.Documents.Hyperlink)element4).Click += this.RegisterLink_Click;
                }
                break;
            case 5: // Views\Login.xaml line 27
                {
                    this.PasswordBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 6: // Views\Login.xaml line 21
                {
                    this.EmailTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

