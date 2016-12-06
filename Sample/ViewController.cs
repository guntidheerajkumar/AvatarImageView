using System;
using AvatarImageView;
using UIKit;
using Foundation;
using CoreGraphics;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			RoundAvatarImageView imageview = new RoundAvatarImageView(new CGRect(70, 50, 200, 200), UIColor.LightGray, UIColor.Red);
			imageview.CacheEnabled = false;
			imageview.SetBackgroundWidth(10f);
			this.View.AddSubview(imageview);
			imageview.SetImageURL(NSUrl.FromString("http://a5.files.biography.com/image/upload/c_fit,cs_srgb,dpr_1.0,h_1200,q_80,w_1200/MTE5NDg0MDU0NTIzODQwMDE1.jpg"));
		}
	}
}
