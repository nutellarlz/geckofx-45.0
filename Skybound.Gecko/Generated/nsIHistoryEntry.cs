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
// Generated by IDLImporter from file nsIHistoryEntry.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// An interface to individual entries in session history. Each
    /// document or frame will have a nsIHistoryEntry associated with
    /// it. nsIHistoryEntry provides access to information like URI,
    /// title and frame traversal status for that document.
    /// This interface is accessible from javascript.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("A41661D4-1417-11D5-9882-00C04FA02F40")]
	public interface nsIHistoryEntry
	{
		
		/// <summary>
        /// A readonly property that returns the URI
        /// of the current entry. The object returned is
        /// of type nsIURI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetURIAttribute();
		
		/// <summary>
        /// A readonly property that returns the title
        /// of the current entry.  The object returned
        /// is a encoded string
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTitleAttribute();
		
		/// <summary>
        /// A readonly property that returns a boolean
        /// flag which indicates if the entry was created as a
        /// result of a subframe navigation. This flag will be
        /// 'false' when a frameset page is visited for
        /// the first time. This flag will be 'true' for all
        /// history entries created as a result of a subframe
        /// navigation.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSubFrameAttribute();
	}
}
