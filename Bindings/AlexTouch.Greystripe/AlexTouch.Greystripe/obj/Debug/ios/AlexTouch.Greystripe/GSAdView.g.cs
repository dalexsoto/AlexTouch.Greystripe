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
	[Register("GSAdView", true)]
	public partial class GSAdView : MonoTouch.UIKit.UIView {
		static IntPtr selAdViewForSlotNamedDelegate_ = Selector.GetHandle ("adViewForSlotNamed:delegate:");
		static IntPtr selAdViewForSlotNamedDelegateRefreshInterval_ = Selector.GetHandle ("adViewForSlotNamed:delegate:refreshInterval:");
		static IntPtr selRefresh = Selector.GetHandle ("refresh");
		
		static IntPtr class_ptr = Class.GetHandle ("GSAdView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("init")]
		public  GSAdView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public GSAdView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public GSAdView (NSObjectFlag t) : base (t) {}

		public GSAdView (IntPtr handle) : base (handle) {}

		[Export ("adViewForSlotNamed:delegate:")]
		public static GSAdView AdViewForSlotNamed (string name, GreystripeDelegate adDelegate)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (adDelegate == null)
				throw new ArgumentNullException ("adDelegate");
			var nsname = new NSString (name);
			
			GSAdView ret;
			ret = (GSAdView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selAdViewForSlotNamedDelegate_, nsname.Handle, adDelegate.Handle));
			nsname.Dispose ();
			
			return ret;
		}
		
		[Export ("adViewForSlotNamed:delegate:refreshInterval:")]
		public static GSAdView AdViewForSlotNamed (string name, GreystripeDelegate adDelegate, System.Double interval)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (adDelegate == null)
				throw new ArgumentNullException ("adDelegate");
			var nsname = new NSString (name);
			
			GSAdView ret;
			ret = (GSAdView) Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Double (class_ptr, selAdViewForSlotNamedDelegateRefreshInterval_, nsname.Handle, adDelegate.Handle, interval));
			nsname.Dispose ();
			
			return ret;
		}
		
		[Export ("refresh")]
		public virtual void Refresh ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRefresh);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRefresh);
			}
		}
		
		static IntPtr __Internal_libraryHandle = Dlfcn.dlopen (null, 0);
		public static System.Double MinimumRefreshInterval {
			get {
				return Dlfcn.GetDouble (__Internal_libraryHandle, "kGSMinimumRefreshInterval");
			}
		}
	} /* class GSAdView */
}
