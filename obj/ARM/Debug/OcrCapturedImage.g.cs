﻿#pragma checksum "C:\Users\Ravi Kandel\Downloads\Compressed\Windows-universal-samples-master\Windows-universal-samples-master\Samples\OCR\cs\OcrCapturedImage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A46A65D248DA9BD376C1EB468D406D7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDKTemplate
{
    partial class OcrCapturedImage : 
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
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.ExtractButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 72 "..\..\..\OcrCapturedImage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ExtractButton).Tapped += this.ExtractButton_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.CameraButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 77 "..\..\..\OcrCapturedImage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CameraButton).Tapped += this.CameraButton_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.PreviewControl = (global::Windows.UI.Xaml.Controls.CaptureElement)(target);
                }
                break;
            case 6:
                {
                    this.Image = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.PreviewImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 67 "..\..\..\OcrCapturedImage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.PreviewImage).SizeChanged += this.PreviewImage_SizeChanged;
                    #line default
                }
                break;
            case 8:
                {
                    this.TextOverlay = (global::Windows.UI.Xaml.Controls.Grid)(target);
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

