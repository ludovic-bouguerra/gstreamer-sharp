// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Pipeline : Gst.Pipeline, Gst.Video.IVideoOverlay {

		public Pipeline (IntPtr raw) : base(raw) {}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_pipeline_new();

		public Pipeline () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Pipeline)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = ges_pipeline_new();
		}

		[GLib.Property ("audio-filter")]
		public Gst.Element AudioFilter {
			get {
				GLib.Value val = GetProperty ("audio-filter");
				Gst.Element ret = (Gst.Element) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("audio-filter", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("audio-sink")]
		public Gst.Element AudioSink {
			get {
				GLib.Value val = GetProperty ("audio-sink");
				Gst.Element ret = (Gst.Element) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("audio-sink", val);
				val.Dispose ();
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int ges_pipeline_get_mode(IntPtr raw);

		[GLib.Property ("mode")]
		public GES.PipelineFlags Mode {
			get  {
				int raw_ret = ges_pipeline_get_mode(Handle);
				GES.PipelineFlags ret = (GES.PipelineFlags) raw_ret;
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("mode", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("timeline")]
		public GES.Timeline Timeline {
			get {
				GLib.Value val = GetProperty ("timeline");
				GES.Timeline ret = (GES.Timeline) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("timeline", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("video-filter")]
		public Gst.Element VideoFilter {
			get {
				GLib.Value val = GetProperty ("video-filter");
				Gst.Element ret = (Gst.Element) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("video-filter", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("video-sink")]
		public Gst.Element VideoSink {
			get {
				GLib.Value val = GetProperty ("video-sink");
				Gst.Element ret = (Gst.Element) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("video-sink", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_ges_reserved"
							, Gst.Pipeline.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_pipeline_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_pipeline_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_pipeline_get_thumbnail(IntPtr raw, IntPtr caps);

		public Gst.Sample GetThumbnail(Gst.Caps caps) {
			IntPtr raw_ret = ges_pipeline_get_thumbnail(Handle, caps == null ? IntPtr.Zero : caps.Handle);
			Gst.Sample ret = raw_ret == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Sample), true);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_pipeline_get_thumbnail_rgb24(IntPtr raw, int width, int height);

		public Gst.Sample GetThumbnailRgb24(int width, int height) {
			IntPtr raw_ret = ges_pipeline_get_thumbnail_rgb24(Handle, width, height);
			Gst.Sample ret = raw_ret == IntPtr.Zero ? null : (Gst.Sample) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Sample), true);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_pipeline_preview_get_audio_sink(IntPtr raw);

		public Gst.Element PreviewGetAudioSink() {
			IntPtr raw_ret = ges_pipeline_preview_get_audio_sink(Handle);
			Gst.Element ret = GLib.Object.GetObject(raw_ret, true) as Gst.Element;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_pipeline_preview_get_video_sink(IntPtr raw);

		public Gst.Element PreviewGetVideoSink() {
			IntPtr raw_ret = ges_pipeline_preview_get_video_sink(Handle);
			Gst.Element ret = GLib.Object.GetObject(raw_ret, true) as Gst.Element;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_pipeline_preview_set_audio_sink(IntPtr raw, IntPtr sink);

		public void PreviewSetAudioSink(Gst.Element sink) {
			ges_pipeline_preview_set_audio_sink(Handle, sink == null ? IntPtr.Zero : sink.Handle);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_pipeline_preview_set_video_sink(IntPtr raw, IntPtr sink);

		public void PreviewSetVideoSink(Gst.Element sink) {
			ges_pipeline_preview_set_video_sink(Handle, sink == null ? IntPtr.Zero : sink.Handle);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool ges_pipeline_save_thumbnail(IntPtr raw, int width, int height, IntPtr format, IntPtr location, out IntPtr error);

		public unsafe bool SaveThumbnail(int width, int height, string format, string location) {
			IntPtr native_format = GLib.Marshaller.StringToPtrGStrdup (format);
			IntPtr native_location = GLib.Marshaller.StringToPtrGStrdup (location);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = ges_pipeline_save_thumbnail(Handle, width, height, native_format, native_location, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_format);
			GLib.Marshaller.Free (native_location);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_pipeline_set_mode(IntPtr raw, int mode);

		public bool SetMode(GES.PipelineFlags mode) {
			bool raw_ret = ges_pipeline_set_mode(Handle, (int) mode);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_pipeline_set_render_settings(IntPtr raw, IntPtr output_uri, IntPtr profile);

		public bool SetRenderSettings(string output_uri, Gst.PbUtils.EncodingProfile profile) {
			IntPtr native_output_uri = GLib.Marshaller.StringToPtrGStrdup (output_uri);
			bool raw_ret = ges_pipeline_set_render_settings(Handle, native_output_uri, profile == null ? IntPtr.Zero : profile.Handle);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_output_uri);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_pipeline_set_timeline(IntPtr raw, IntPtr timeline);

		public bool SetTimeline(GES.Timeline timeline) {
			bool raw_ret = ges_pipeline_set_timeline(Handle, timeline == null ? IntPtr.Zero : timeline.OwnedHandle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_overlay_expose(IntPtr raw);

		public void Expose() {
			gst_video_overlay_expose(Handle);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_overlay_got_window_handle(IntPtr raw, IntPtr handle);

		public void GotWindowHandle(IntPtr handle) {
			gst_video_overlay_got_window_handle(Handle, handle);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_overlay_handle_events(IntPtr raw, bool handle_events);

		public void HandleEvents(bool handle_events) {
			gst_video_overlay_handle_events(Handle, handle_events);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_overlay_prepare_window_handle(IntPtr raw);

		public void PrepareWindowHandle() {
			gst_video_overlay_prepare_window_handle(Handle);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_overlay_set_render_rectangle(IntPtr raw, int x, int y, int width, int height);

		public bool SetRenderRectangle(int x, int y, int width, int height) {
			bool raw_ret = gst_video_overlay_set_render_rectangle(Handle, x, y, width, height);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_overlay_set_window_handle(IntPtr raw, IntPtr handle);

		public IntPtr WindowHandle { 
			set {
				gst_video_overlay_set_window_handle(Handle, value);
			}
		}


		static Pipeline ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.Pipeline.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
