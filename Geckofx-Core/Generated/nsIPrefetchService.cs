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
// Generated by IDLImporter from file nsIPrefetchService.idl
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

	
	
	/// <summary>nsIPrefetchService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cba513eb-c457-4b93-832c-1a979e66edd1")]
	public interface nsIPrefetchService
	{
		
		/// <summary>
        /// Enqueue a request to prefetch the specified URI.
        ///
        /// @param aURI the URI of the document to prefetch
        /// @param aReferrerURI the URI of the referring page
        /// @param aSource the DOM node (such as a <link> tag) that requested this
        /// fetch, or null if the prefetch was not requested by a DOM node.
        /// @param aExplicit the link element has an explicit prefetch link type
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrefetchURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrerURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aSource, [MarshalAs(UnmanagedType.U1)] bool aExplicit);
		
		/// <summary>
        /// @status DEPRECATED This method is no longer used, and will throw
        /// NS_ERROR_NOT_IMPLEMENTED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrefetchURIForOfflineUse([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrerURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode aSource, [MarshalAs(UnmanagedType.U1)] bool aExplicit);
		
		/// <summary>
        /// Enumerate the items in the prefetch queue.  Each element in the
        /// enumeration is an nsIDOMLoadStatus.
        ///
        /// @param aIncludeNormalItems include normal prefetch items in the
        /// list.  This parameter is deprecated and must be TRUE,
        /// or NS_ERROR_INT_IMPLEMENTED will be thrown.
        /// @param aIncludeOfflineItems include items being fetched for offline
        /// use.  This parameter is deprecated and must be FALSE,
        /// or NS_ERROR_NOT_IMPLEMENTED will be thrown.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator EnumerateQueue([MarshalAs(UnmanagedType.U1)] bool aIncludeNormalItems, [MarshalAs(UnmanagedType.U1)] bool aIncludeOfflineItems);
	}
}