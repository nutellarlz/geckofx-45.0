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
// Generated by IDLImporter from file nsIApplicationCache.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// Application caches can store a set of namespace entries that affect
    /// loads from the application cache.  If a load from the cache fails
    /// to match an exact cache entry, namespaces entries will be searched
    /// for a substring match, and should be applied appropriately.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("96e4c264-2065-4ce9-93bb-43734c62c4eb")]
	public interface nsIApplicationCacheNamespace
	{
		
		/// <summary>
        /// Initialize the namespace.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init(uint itemType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase namespaceSpec, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase data);
		
		/// <summary>
        /// The namespace type.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetItemTypeAttribute();
		
		/// <summary>
        /// The prefix of this namespace.  This should be the asciiSpec of the
        /// URI prefix.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNamespaceSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNamespaceSpec);
		
		/// <summary>
        /// Data associated with this namespace, such as a fallback.  URI data should
        /// use the asciiSpec of the URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDataAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aData);
	}
	
	/// <summary>
    /// Application caches store resources for offline use.  Each
    /// application cache has a unique client ID for use with
    /// nsICacheService::openSession() to access the cache's entries.
    ///
    /// Each entry in the application cache can be marked with a set of
    /// types, as discussed in the WHAT-WG offline applications
    /// specification.
    ///
    /// All application caches with the same group ID belong to a cache
    /// group.  Each group has one "active" cache that will service future
    /// loads.  Inactive caches will be removed from the cache when they are
    /// no longer referenced.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("32f83e3f-470c-4423-a86a-d35d1c215ccb")]
	public interface nsIApplicationCache
	{
		
		/// <summary>
        /// Init this application cache instance to just hold the group ID and
        /// the client ID to work just as a handle to the real cache. Used on
        /// content process to simplify the application cache code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitAsHandle([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase groupId, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase clientId);
		
		/// <summary>
        /// The group ID for this cache group.  This is the URI of the
        /// manifest file.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetGroupIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aGroupID);
		
		/// <summary>
        /// The client ID for this application cache.  Clients can open a
        /// session with nsICacheService::createSession() using this client
        /// ID and a storage policy of STORE_OFFLINE to access this cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClientIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aClientID);
		
		/// <summary>
        /// TRUE if the cache is the active cache for this group.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetActiveAttribute();
		
		/// <summary>
        /// The disk usage of the application cache, in bytes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetUsageAttribute();
		
		/// <summary>
        /// Makes this cache the active application cache for this group.
        /// Future loads associated with this group will come from this
        /// cache.  Other caches from this cache group will be deactivated.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Activate();
		
		/// <summary>
        /// Discard this application cache.  Removes all cached resources
        /// for this cache.  If this is the active application cache for the
        /// group, the group will be removed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Discard();
		
		/// <summary>
        /// Adds item types to a given entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkEntry([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, uint typeBits);
		
		/// <summary>
        /// Removes types from a given entry.  If the resulting entry has
        /// no types left, the entry is removed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnmarkEntry([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, uint typeBits);
		
		/// <summary>
        /// Gets the types for a given entry.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetTypes([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key);
		
		/// <summary>
        /// Returns any entries in the application cache whose type matches
        /// one or more of the bits in typeBits.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GatherEntries(uint typeBits, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref string[] keys);
		
		/// <summary>
        /// Add a set of namespace entries to the application cache.
        /// @param namespaces
        /// An nsIArray of nsIApplicationCacheNamespace entries.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddNamespaces([MarshalAs(UnmanagedType.Interface)] nsIArray namespaces);
		
		/// <summary>
        /// Get the most specific namespace matching a given key.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIApplicationCacheNamespace GetMatchingNamespace([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key);
	}
}
