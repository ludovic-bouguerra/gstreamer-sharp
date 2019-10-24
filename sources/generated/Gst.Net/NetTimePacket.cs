// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Net {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct NetTimePacket : IEquatable<NetTimePacket> {

		public ulong LocalTime;
		public ulong RemoteTime;

		public static Gst.Net.NetTimePacket Zero = new Gst.Net.NetTimePacket ();

		public static Gst.Net.NetTimePacket New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Net.NetTimePacket.Zero;
			return (Gst.Net.NetTimePacket) Marshal.PtrToStructure (raw, typeof (Gst.Net.NetTimePacket));
		}

		[DllImport("gstnet-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_net_time_packet_new(byte[] buffer);

		public static NetTimePacket New(byte[] buffer)
		{
			NetTimePacket result = NetTimePacket.New (gst_net_time_packet_new(buffer));
			return result;
		}

		[DllImport("gstnet-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_net_time_packet_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_net_time_packet_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstnet-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_net_time_packet_send(IntPtr raw, IntPtr socket, IntPtr dest_address, out IntPtr error);

		public unsafe bool Send(GLib.Socket socket, GLib.SocketAddress dest_address) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_net_time_packet_send(this_as_native, socket == null ? IntPtr.Zero : socket.Handle, dest_address == null ? IntPtr.Zero : dest_address.Handle, out error);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gstnet-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern byte gst_net_time_packet_serialize(IntPtr raw);

		public byte Serialize() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			byte raw_ret = gst_net_time_packet_serialize(this_as_native);
			byte ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("gstnet-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gst_net_time_packet_receive(IntPtr socket, out IntPtr src_address, out IntPtr error);

		public static unsafe Gst.Net.NetTimePacket Receive(GLib.Socket socket, out GLib.SocketAddress src_address) {
			IntPtr native_src_address;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gst_net_time_packet_receive(socket == null ? IntPtr.Zero : socket.Handle, out native_src_address, out error);
			Gst.Net.NetTimePacket ret = Gst.Net.NetTimePacket.New (raw_ret);
			src_address = GLib.Object.GetObject(native_src_address, true) as GLib.SocketAddress;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Net.NetTimePacket target)
		{
			target = New (native);
		}

		public bool Equals (NetTimePacket other)
		{
			return true && LocalTime.Equals (other.LocalTime) && RemoteTime.Equals (other.RemoteTime);
		}

		public override bool Equals (object other)
		{
			return other is NetTimePacket && Equals ((NetTimePacket) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ LocalTime.GetHashCode () ^ RemoteTime.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Net.NetTimePacket boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Net.NetTimePacket.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Net.NetTimePacket (GLib.Value val)
		{
			return (Gst.Net.NetTimePacket) val.Val;
		}
#endregion
	}
}
