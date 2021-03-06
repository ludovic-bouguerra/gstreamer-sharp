// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GESSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool FillTrackElementFuncNative(IntPtr clip, IntPtr track_element, IntPtr nleobj);

	internal class FillTrackElementFuncInvoker {

		FillTrackElementFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FillTrackElementFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FillTrackElementFuncInvoker (FillTrackElementFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FillTrackElementFuncInvoker (FillTrackElementFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FillTrackElementFuncInvoker (FillTrackElementFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GES.FillTrackElementFunc Handler {
			get {
				return new GES.FillTrackElementFunc(InvokeNative);
			}
		}

		bool InvokeNative (GES.Clip clip, GES.TrackElement track_element, Gst.Element nleobj)
		{
			bool __result = native_cb (clip == null ? IntPtr.Zero : clip.Handle, track_element == null ? IntPtr.Zero : track_element.Handle, nleobj == null ? IntPtr.Zero : nleobj.Handle);
			return __result;
		}
	}

	internal class FillTrackElementFuncWrapper {

		public bool NativeCallback (IntPtr clip, IntPtr track_element, IntPtr nleobj)
		{
			try {
				bool __ret = managed (GLib.Object.GetObject(clip) as GES.Clip, GLib.Object.GetObject(track_element) as GES.TrackElement, GLib.Object.GetObject(nleobj) as Gst.Element);
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal FillTrackElementFuncNative NativeDelegate;
		GES.FillTrackElementFunc managed;

		public FillTrackElementFuncWrapper (GES.FillTrackElementFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FillTrackElementFuncNative (NativeCallback);
		}

		public static GES.FillTrackElementFunc GetManagedDelegate (FillTrackElementFuncNative native)
		{
			if (native == null)
				return null;
			FillTrackElementFuncWrapper wrapper = (FillTrackElementFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
