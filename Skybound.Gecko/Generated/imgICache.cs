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
// Generated by IDLImporter from file imgICache.idl
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
    /// imgICache interface
    ///
    /// @author Stuart Parmenter <pavlov@netscape.com>
    /// @version 0.1
    /// @see imagelib2
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f1b74aae-5661-4753-a21c-66dd644afebc")]
	public interface imgICache
	{
		
		/// <summary>
        /// Evict images from the cache.
        ///
        /// @param chrome If TRUE,  evict only chrome images.
        /// If FALSE, evict everything except chrome images.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearCache(System.Boolean  chrome);
		
		/// <summary>
        /// Evict images from the cache.
        ///
        /// @param uri The URI to remove.
        /// @return NS_OK if \a uri was removed from the cache.
        /// NS_ERROR_NOT_AVAILABLE if \a uri was unable to be removed from the cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEntry([MarshalAs(UnmanagedType.Interface)] nsIURI  uri);
		
		/// <summary>
        /// Find Properties
        /// Used to get properties such as 'type' and 'content-disposition'
        /// 'type' is a nsISupportsCString containing the images' mime type such as 'image/png'
        /// 'content-disposition' will be a nsISupportsCString containing the header
        /// If you call this before any data has been loaded from a URI, it will succeed,
        /// but come back empty.
        ///
        /// @param uri The URI to look up.
        /// @returns NULL if the URL was not found in the cache
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProperties FindEntryProperties([MarshalAs(UnmanagedType.Interface)] nsIURI  uri);
	}
}
