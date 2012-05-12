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
	[Register("GSAdEngine", true)]
	public partial class GSAdEngine : NSObject {
		static IntPtr selVersion = Selector.GetHandle ("version");
		static IntPtr selHashedDeviceIdentifier = Selector.GetHandle ("hashedDeviceIdentifier");
		static IntPtr selStartupWithAppIDAdSlotDescriptions_ = Selector.GetHandle ("startupWithAppID:adSlotDescriptions:");
		static IntPtr selDisplayFullScreenAdForSlotNamed_ = Selector.GetHandle ("displayFullScreenAdForSlotNamed:");
		static IntPtr selSetFullScreenDelegateForSlotNamed_ = Selector.GetHandle ("setFullScreenDelegate:forSlotNamed:");
		static IntPtr selIsAdReadyForSlotNamed_ = Selector.GetHandle ("isAdReadyForSlotNamed:");
		static IntPtr selIsNextAdDownloadedForSlotNamed_ = Selector.GetHandle ("isNextAdDownloadedForSlotNamed:");
		
		static IntPtr class_ptr = Class.GetHandle ("GSAdEngine");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("init")]
		public  GSAdEngine () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public GSAdEngine (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public GSAdEngine (NSObjectFlag t) : base (t) {}

		public GSAdEngine (IntPtr handle) : base (handle) {}

		[Export ("startupWithAppID:adSlotDescriptions:")]
		public static void StartupWithAppIDAdSlotDescriptions (string appID, GSAdSlotDescription[] descriptions)
		{
			if (appID == null)
				throw new ArgumentNullException ("appID");
			if (descriptions == null)
				throw new ArgumentNullException ("descriptions");
			var nsappID = new NSString (appID);
			var nsa_descriptions = NSArray.FromNSObjects (descriptions);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selStartupWithAppIDAdSlotDescriptions_, nsappID.Handle, nsa_descriptions.Handle);
			nsappID.Dispose ();
			nsa_descriptions.Dispose ();
			
		}
		
		[Export ("displayFullScreenAdForSlotNamed:")]
		public static bool DisplayFullScreenAdForSlotNamed (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = new NSString (name);
			
			bool ret;
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selDisplayFullScreenAdForSlotNamed_, nsname.Handle);
			nsname.Dispose ();
			
			return ret;
		}
		
		[Export ("setFullScreenDelegate:forSlotNamed:")]
		public static void SetFullScreenDelegateForSlotNamed (GreystripeDelegate adDelegate, string name)
		{
			if (adDelegate == null)
				throw new ArgumentNullException ("adDelegate");
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = new NSString (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selSetFullScreenDelegateForSlotNamed_, adDelegate.Handle, nsname.Handle);
			nsname.Dispose ();
			
		}
		
		[Export ("isAdReadyForSlotNamed:")]
		public static bool IsAdReadyForSlotNamed (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = new NSString (name);
			
			bool ret;
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selIsAdReadyForSlotNamed_, nsname.Handle);
			nsname.Dispose ();
			
			return ret;
		}
		
		[Export ("isNextAdDownloadedForSlotNamed:")]
		public static bool IsNextAdDownloadedForSlotNamed (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = new NSString (name);
			
			bool ret;
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selIsNextAdDownloadedForSlotNamed_, nsname.Handle);
			nsname.Dispose ();
			
			return ret;
		}
		
		public static string Version {
			[Export ("version")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selVersion));
			}
			
		}
		
		public static string HashedDeviceIdentifier {
			[Export ("hashedDeviceIdentifier")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selHashedDeviceIdentifier));
			}
			
		}
		
	} /* class GSAdEngine */
}
