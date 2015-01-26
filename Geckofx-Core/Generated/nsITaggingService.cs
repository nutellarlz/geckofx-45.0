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
// Generated by IDLImporter from file nsITaggingService.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f816b4df-f733-4dbd-964d-8bfc92a475b2")]
	public interface nsITaggingService
	{
		
		/// <summary>
        /// Tags a URL with the given set of tags. Current tags set for the URL
        /// persist. Tags in aTags which are already set for the given URL are
        /// ignored.
        ///
        /// @param aURI
        /// the URL to tag.
        /// @param aTags
        /// Array of tags to set for the given URL.  Each element within the
        /// array can be either a tag name (non-empty string) or a concrete
        /// itemId of a tag container.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TagURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIVariant aTags);
		
		/// <summary>
        /// Removes tags from a URL. Tags from aTags which are not set for the
        /// given URL are ignored.
        ///
        /// @param aURI
        /// the URL to un-tag.
        /// @param aTags
        /// Array of tags to unset.  Pass null to remove all tags from the given
        /// url.  Each element within the array can be either a tag name
        /// (non-empty string) or a concrete itemId of a tag container.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UntagURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIVariant aTags);
		
		/// <summary>
        /// Retrieves all URLs tagged with the given tag.
        ///
        /// @param aTag
        /// tag name
        /// @returns Array of uris tagged with aTag.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetURIsForTag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTag);
		
		/// <summary>
        /// Retrieves all tags set for the given URL.
        ///
        /// @param aURI
        /// a URL.
        /// @returns array of tags (sorted by name).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTagsForURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref System.IntPtr[] aTags);
		
		/// <summary>
        /// Retrieves all tags used to tag URIs in the data-base (sorted by name).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetAllTagsAttribute();
		
		/// <summary>
        /// Whether any tags exist.
        ///
        /// @note This is faster than allTags.length, since doesn't need to sort tags.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasTagsAttribute();
	}
}
