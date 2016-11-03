using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AvatarImageView
{
	// @protocol RoundAvatarImageViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RoundAvatarImageViewDelegate
	{
		// @optional -(void)RoundAvatarImageViewDidTapped:(id)view;
		[Export("RoundAvatarImageViewDidTapped:")]
		void RoundAvatarImageViewDidTapped(NSObject view);
	}

	// @interface RoundAvatarImageView : UIView
	[BaseType(typeof(UIView))]
	interface RoundAvatarImageView
	{
		[Wrap("WeakDelegate")]
		RoundAvatarImageViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<RoundAvatarImageViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (getter = isCacheEnabled, assign, nonatomic) BOOL cacheEnabled;
		[Export("cacheEnabled")]
		bool CacheEnabled { [Bind("isCacheEnabled")] get; set; }

		// @property (nonatomic, strong) UIImage * placeHolderImage;
		[Export("placeHolderImage", ArgumentSemantic.Strong)]
		UIImage PlaceHolderImage { get; set; }

		// @property (readonly, nonatomic, strong) UIImageView * containerImageView;
		[Export("containerImageView", ArgumentSemantic.Strong)]
		UIImageView ContainerImageView { get; }

		// @property (nonatomic, strong) UIColor * backgroundProgresscolor;
		[Export("backgroundProgresscolor", ArgumentSemantic.Strong)]
		UIColor BackgroundProgresscolor { get; set; }

		// @property (nonatomic, strong) UIColor * progressColor;
		[Export("progressColor", ArgumentSemantic.Strong)]
		UIColor ProgressColor { get; set; }

		// -(id)initWithFrame:(CGRect)frame backgroundProgressColor:(UIColor *)backgroundProgresscolor progressColor:(UIColor *)progressColor;
		[Export("initWithFrame:backgroundProgressColor:progressColor:")]
		IntPtr Constructor(CGRect frame, UIColor backgroundProgresscolor, UIColor progressColor);

		// -(void)setImageURL:(NSURL *)URL;
		[Export("setImageURL:")]
		void SetImageURL(NSUrl URL);

		// -(void)setImageURL:(NSURL *)URL completion:(void (^)(NSError *))completionBlock;
		[Export("setImageURL:completion:")]
		void SetImageURL(NSUrl URL, Action<NSError> completionBlock);

		// -(void)setImage:(UIImage *)image;
		[Export("setImage:")]
		void SetImage(UIImage image);

		// -(void)setBackgroundWidth:(CGFloat)width;
		[Export("setBackgroundWidth:")]
		void SetBackgroundWidth(nfloat width);
	}
}
