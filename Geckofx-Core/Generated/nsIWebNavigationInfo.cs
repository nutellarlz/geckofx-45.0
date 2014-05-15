// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIWebNavigationInfo.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// The nsIWebNavigationInfo interface exposes a way to get information
    /// on the capabilities of Gecko webnavigation objects.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("62a93afb-93a1-465c-84c8-0432264229de")]
	public interface nsIWebNavigationInfo
	{
		
		/// <summary>
        /// Query whether aType is supported.
        /// @param aType the MIME type in question.
        /// @param aWebNav the nsIWebNavigation object for which the request
        /// is being made.  This is allowed to be null.  If it is non-null,
        /// the return value of this method may depend on the exact state of
        /// aWebNav and the values set through nsIWebBrowserSetup; otherwise
        /// the method will assume that the caller is interested in information
        /// about nsIWebNavigation objects in their default state.
        /// @return an enum value indicating whether and how aType is supported.
        /// @note This method may rescan plugins to ensure that they're properly
        /// registered for the types they support.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint IsTypeSupported([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType, [MarshalAs(UnmanagedType.Interface)] nsIWebNavigation aWebNav);
	}
	
	/// <summary>nsIWebNavigationInfoConsts </summary>
	public class nsIWebNavigationInfoConsts
	{
		
		// <summary>
        // Returned by isTypeSupported to indicate lack of support for a type.
        // @note this is guaranteed not to change, so that boolean tests can be done
        // on the return value if isTypeSupported to detect whether a type is
        // supported at all.
        // </summary>
		public const ulong UNSUPPORTED = 0;
		
		// <summary>
        // Returned by isTypeSupported to indicate that a type is supported as an
        // image.
        // </summary>
		public const ulong IMAGE = 1;
		
		// <summary>
        // Returned by isTypeSupported to indicate that a type is supported via an
        // NPAPI ("Netscape 4 API") plug-in.  This is not the value returned for
        // "XPCOM plug-ins".
        // </summary>
		public const ulong PLUGIN = 2;
		
		// <summary>
        // Returned by isTypeSupported to indicate that a type is supported via some
        // other means.
        // </summary>
		public const ulong OTHER = 1<<15;
	}
}
