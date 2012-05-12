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
	[Register("GSAdSlotDescription", true)]
	public partial class GSAdSlotDescription : NSObject {
		static IntPtr selSize = Selector.GetHandle ("size");
		static IntPtr selName = Selector.GetHandle ("name");
		static IntPtr selDescriptionWithSizeName_ = Selector.GetHandle ("descriptionWithSize:name:");
		static IntPtr selInitWithSizeName_ = Selector.GetHandle ("initWithSize:name:");
		
		static IntPtr class_ptr = Class.GetHandle ("GSAdSlotDescription");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("init")]
		public  GSAdSlotDescription () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public GSAdSlotDescription (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public GSAdSlotDescription (NSObjectFlag t) : base (t) {}

		public GSAdSlotDescription (IntPtr handle) : base (handle) {}

		[Export ("descriptionWithSize:name:")]
		public static GSAdSlotDescription DescriptionWithSizeName (GSAdSize size, string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = new NSString (name);
			
			GSAdSlotDescription ret;
			ret = (GSAdSlotDescription) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int_IntPtr (class_ptr, selDescriptionWithSizeName_, (int)size, nsname.Handle));
			nsname.Dispose ();
			
			return ret;
		}
		
		[Export ("initWithSize:name:")]
		public GSAdSlotDescription (GSAdSize size, string name) : base (NSObjectFlag.Empty)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = new NSString (name);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int_IntPtr (this.Handle, selInitWithSizeName_, (int)size, nsname.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int_IntPtr (this.SuperHandle, selInitWithSizeName_, (int)size, nsname.Handle);
			}
			nsname.Dispose ();
			
		}
		
		public virtual GSAdSize Size {
			[Export ("size")]
			get {
				if (IsDirectBinding) {
					return (GSAdSize) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSize);
				} else {
					return (GSAdSize) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSize);
				}
			}
			
		}
		
		public virtual string Name {
			[Export ("name")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selName));
				}
			}
			
		}
		
	} /* class GSAdSlotDescription */
}
