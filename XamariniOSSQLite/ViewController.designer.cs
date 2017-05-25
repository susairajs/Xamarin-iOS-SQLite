// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSSQLite
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCreate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnInsert { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDBName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDisplay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtAge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtName { get; set; }

        [Action ("BtnCreate_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnCreate_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnInsert_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnInsert_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCreate != null) {
                btnCreate.Dispose ();
                btnCreate = null;
            }

            if (btnInsert != null) {
                btnInsert.Dispose ();
                btnInsert = null;
            }

            if (lblDBName != null) {
                lblDBName.Dispose ();
                lblDBName = null;
            }

            if (lblDisplay != null) {
                lblDisplay.Dispose ();
                lblDisplay = null;
            }

            if (txtAge != null) {
                txtAge.Dispose ();
                txtAge = null;
            }

            if (txtName != null) {
                txtName.Dispose ();
                txtName = null;
            }
        }
    }
}