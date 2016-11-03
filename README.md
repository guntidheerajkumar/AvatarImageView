# AvatarImageView

This is a Obj-C Binding Project based on https://github.com/abiaad/PAAImageView

Rounded async imageview downloader based on AFNetworking 2 and cached

```
RoundAvatarImageView imageview = new RoundAvatarImageView(new CGRect(70, 50, 200, 200), UIColor.LightGray, UIColor.Red);
imageview.CacheEnabled = false;
imageview.SetBackgroundWidth(10f);
this.View.AddSubview(imageview);
imageview.SetImageURL(<<Image URL>>);
```
