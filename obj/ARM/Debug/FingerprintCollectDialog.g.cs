﻿#pragma checksum "F:\Liy Personal Last\工作\Projects\Work Projects\QDRDTFS\平行管理系统\源代码\PHR\PAM\FingerprintCollectDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DF5369D2E36D32B7DD7B22C487793BC7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PAM
{
    partial class FingerprintCollectDialog : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
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
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    #line 10 "..\..\..\FingerprintCollectDialog.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).SecondaryButtonClick += this.ContentDialog_CloseButtonClick;
                    #line default
                }
                break;
            case 2:
                {
                    this.brdOne = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 3:
                {
                    this.brdTwo = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 4:
                {
                    this.brdThree = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 5:
                {
                    this.image3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6:
                {
                    this.image2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.image1 = (global::Windows.UI.Xaml.Controls.Image)(target);
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
