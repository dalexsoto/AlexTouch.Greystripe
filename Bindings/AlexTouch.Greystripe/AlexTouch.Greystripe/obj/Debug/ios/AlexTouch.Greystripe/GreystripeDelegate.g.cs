//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;

using System.Drawing;

using System.Runtime.InteropServices;

using MonoTouch;

using MonoTouch.CoreFoundation;

using MonoTouch.CoreMedia;

using MonoTouch.CoreMotion;

using MonoTouch.Foundation;

using MonoTouch.ObjCRuntime;

using MonoTouch.CoreAnimation;

using MonoTouch.CoreLocation;

using MonoTouch.MapKit;

using MonoTouch.UIKit;

using MonoTouch.CoreGraphics;

using MonoTouch.NewsstandKit;

using MonoTouch.GLKit;

using OpenTK;

namespace AlexTouch.Greystripe {
	[Register("GreystripeDelegate", true)]
	[Model]
	public partial class GreystripeDelegate : NSObject {
		
		static IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[Export ("init")]
		public  GreystripeDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public GreystripeDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public GreystripeDelegate (NSObjectFlag t) : base (t) {}

		public GreystripeDelegate (IntPtr handle) : base (handle) {}

		[Export ("greystripeAdReadyForSlotNamed:")]
		public virtual void GreystripeAdReadyForSlotNamed (string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("greystripeFullScreenDisplayWillOpen")]
		public virtual void GreystripeFullScreenDisplayWillOpen ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("greystripeFullScreenDisplayWillClose")]
		public virtual void GreystripeFullScreenDisplayWillClose ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("greystripeDidReceiveMemoryWarning")]
		public virtual void GreystripeDidReceiveMemoryWarning ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class GreystripeDelegate */
}
