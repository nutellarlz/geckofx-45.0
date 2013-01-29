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
// Generated by IDLImporter from file nsIDOMOfflineResourceList.idl
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
	[Guid("f394a721-66e9-46fc-bb24-b980bb732dd0")]
	public interface nsIDOMOfflineResourceList
	{
		
		/// <summary>
        /// Get the list of dynamically-managed entries.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetMozItemsAttribute();
		
		/// <summary>
        /// Check that an entry exists in the list of dynamically-managed entries.
        ///
        /// @param uri
        /// The resource to check.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool MozHasItem([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri);
		
		/// <summary>
        /// Get the number of dynamically-managed entries.
        /// @status DEPRECATED
        /// Clients should use the "items" attribute.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMozLengthAttribute();
		
		/// <summary>
        /// Get the URI of a dynamically-managed entry.
        /// @status DEPRECATED
        /// Clients should use the "items" attribute.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozItem(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Add an item to the list of dynamically-managed entries.  The resource
        /// will be fetched into the application cache.
        ///
        /// @param uri
        /// The resource to add.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozAdd([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri);
		
		/// <summary>
        /// Remove an item from the list of dynamically-managed entries.  If this
        /// was the last reference to a URI in the application cache, the cache
        /// entry will be removed.
        ///
        /// @param uri
        /// The resource to remove.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MozRemove([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetStatusAttribute();
		
		/// <summary>
        /// Begin the application update process on the associated application cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Update();
		
		/// <summary>
        /// Swap in the newest version of the application cache, or disassociate
        /// from the cache if the cache group is obsolete.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SwapCache();
		
		/// <summary>
        ///Events </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOncheckingAttribute();
		
		/// <summary>
        ///Events </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncheckingAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnchecking);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnerrorAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnerror);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnnoupdateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnnoupdateAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnnoupdate);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOndownloadingAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndownloadingAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOndownloading);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnprogressAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnprogress);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnupdatereadyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnupdatereadyAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnupdateready);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOncachedAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncachedAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOncached);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnobsoleteAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnobsoleteAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnobsolete);
	}
	
	/// <summary>nsIDOMOfflineResourceListConsts </summary>
	public class nsIDOMOfflineResourceListConsts
	{
		
		// <summary>
        //This object is not associated with an application cache. </summary>
		public const ulong UNCACHED = 0;
		
		// <summary>
        //The application cache is not being updated. </summary>
		public const ulong IDLE = 1;
		
		// <summary>
        //The manifest is being fetched and checked for updates </summary>
		public const ulong CHECKING = 2;
		
		// <summary>
        //Resources are being downloaded to be added to the cache </summary>
		public const ulong DOWNLOADING = 3;
		
		// <summary>
        //There is a new version of the application cache available </summary>
		public const ulong UPDATEREADY = 4;
		
		// <summary>
        //The application cache group is now obsolete. </summary>
		public const ulong OBSOLETE = 5;
	}
}
