// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VideoDirectionAdapter : GLib.GInterfaceAdapter, Gst.Video.IVideoDirection {

		[StructLayout (LayoutKind.Sequential)]
		struct GstVideoDirectionInterface {
		}

		static GstVideoDirectionInterface iface;

		static VideoDirectionAdapter ()
		{
			GLib.GType.Register (_gtype, typeof (VideoDirectionAdapter));
		}

		static void Initialize (IntPtr ptr, IntPtr data)
		{
		}

		GLib.Object implementor;

		public VideoDirectionAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		public VideoDirectionAdapter (IVideoDirectionImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			else if (!(implementor is GLib.Object))
				throw new ArgumentException ("implementor must be a subclass of GLib.Object");
			this.implementor = implementor as GLib.Object;
		}

		public VideoDirectionAdapter (IntPtr handle)
		{
			if (!_gtype.IsInstance (handle))
				throw new ArgumentException ("The gobject doesn't implement the GInterface of this adapter", "handle");
			implementor = GLib.Object.GetObject (handle);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_direction_get_type();

		private static GLib.GType _gtype = new GLib.GType (gst_video_direction_get_type ());

		public static GLib.GType GType {
			get {
				return _gtype;
			}
		}

		public override GLib.GType GInterfaceGType {
			get {
				return _gtype;
			}
		}

		public override IntPtr Handle {
			get {
				return implementor.Handle;
			}
		}

		public IntPtr OwnedHandle {
			get {
				return implementor.OwnedHandle;
			}
		}

		public static IVideoDirection GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static IVideoDirection GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is IVideoDirectionImplementor)
				return new VideoDirectionAdapter (obj as IVideoDirectionImplementor);
			else if (obj as IVideoDirection == null)
				return new VideoDirectionAdapter (obj.Handle);
			else
				return obj as IVideoDirection;
		}

		public IVideoDirectionImplementor Implementor {
			get {
				return implementor as IVideoDirectionImplementor;
			}
		}

		[GLib.Property ("video-direction")]
		public Gst.Video.VideoOrientationMethod VideoDirection {
			get {
				GLib.Value val = implementor.GetProperty ("video-direction");
				Gst.Video.VideoOrientationMethod ret = (Gst.Video.VideoOrientationMethod) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				implementor.SetProperty("video-direction", val);
				val.Dispose ();
			}
		}

#endregion
	}
}
