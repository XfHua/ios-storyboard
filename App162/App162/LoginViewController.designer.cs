// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace App162
{
    [Register ("LoginViewController")]
    partial class LoginViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Mybutton { get; set; }

        [Action ("Mybutton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Mybutton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Mybutton != null) {
                Mybutton.Dispose ();
                Mybutton = null;
            }
        }
    }
}