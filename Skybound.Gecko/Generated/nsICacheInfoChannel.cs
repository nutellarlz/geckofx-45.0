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
// Generated by IDLImporter from file nsICacheInfoChannel.idl
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
	
	
	/// <summary>nsICacheInfoChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("299d69b4-ee86-4541-802d-7642671ebf97")]
	public interface nsICacheInfoChannel
	{
		
		/// <summary>
        /// Get expiration time from cache token. This attribute is equivalent to
        /// nsICachingChannel.cacheToken.expirationTime.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetCacheTokenExpirationTimeAttribute();
		
		/// <summary>
        /// Set/get charset of cache entry. Accessing this attribute is equivalent to
        /// calling nsICachingChannel.cacheToken.getMetaDataElement("charset") and
        /// nsICachingChannel.cacheToken.setMetaDataElement("charset").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCacheTokenCachedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aCacheTokenCachedCharset);
		
		/// <summary>
        /// Set/get charset of cache entry. Accessing this attribute is equivalent to
        /// calling nsICachingChannel.cacheToken.getMetaDataElement("charset") and
        /// nsICachingChannel.cacheToken.setMetaDataElement("charset").
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCacheTokenCachedCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aCacheTokenCachedCharset);
		
		/// <summary>
        /// TRUE if this channel's data is being loaded from the cache.  This value
        /// is undefined before the channel fires its OnStartRequest notification
        /// and after the channel fires its OnStopRequest notification.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsFromCache();
	}
}
