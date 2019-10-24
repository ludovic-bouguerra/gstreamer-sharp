// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Tags {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Tags.TagLicenseFlagsGType))]
	public enum TagLicenseFlags {

		PermitsReproduction = 1,
		PermitsDistribution = 2,
		PermitsDerivativeWorks = 4,
		PermitsSharing = 8,
		RequiresNotice = 256,
		RequiresAttribution = 512,
		RequiresShareAlike = 1024,
		RequiresSourceCode = 2048,
		RequiresCopyleft = 4096,
		RequiresLesserCopyleft = 8192,
		ProhibitsCommercialUse = 65536,
		ProhibitsHighIncomeNationUse = 131072,
		CreativeCommonsLicense = 16777216,
		FreeSoftwareFoundationLicense = 33554432,
	}

	internal class TagLicenseFlagsGType {
		[DllImport ("gsttag-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_tag_license_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_tag_license_flags_get_type ());
			}
		}
	}
#endregion
}
