﻿#pragma checksum "D:\MojeProjekty\My_Projects\Mp3Player\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "693C4DECAA2E279EAE2949C09912F599"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mp3Player
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.MyStory = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 3: // MainPage.xaml line 132
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Button_Click;
                }
                break;
            case 4: // MainPage.xaml line 115
                {
                    this.Play = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play).PointerEntered += this.element_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play).PointerExited += this.element_PointerExited;
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play).Click += this.Play_Click;
                }
                break;
            case 5: // MainPage.xaml line 123
                {
                    this.Stop = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Stop).PointerEntered += this.element_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Stop).PointerExited += this.element_PointerExited;
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.Stop).Click += this.Stop_Click;
                }
                break;
            case 6: // MainPage.xaml line 99
                {
                    this.___Rectangle_Anim = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 7: // MainPage.xaml line 81
                {
                    this.LoadedText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // MainPage.xaml line 88
                {
                    this.mediaPlayer = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

