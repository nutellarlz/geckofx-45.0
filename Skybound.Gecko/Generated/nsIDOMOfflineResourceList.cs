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
	using System.Windows.Forms;
	
	
	/// <summary>nsIDOMOfflineResourceList </summary>
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
		[return: MarshalAs(UnmanagedType.Bool)]
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
		
		/// <summary>
        ///The application cache group is now obsolete. </summary>
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
		
		/// <summary>Member GetOnerrorAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnerrorAttribute();
		
		/// <summary>Member SetOnerrorAttribute </summary>
		/// <param name='aOnerror'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnerror);
		
		/// <summary>Member GetOnnoupdateAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnnoupdateAttribute();
		
		/// <summary>Member SetOnnoupdateAttribute </summary>
		/// <param name='aOnnoupdate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnnoupdateAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnnoupdate);
		
		/// <summary>Member GetOndownloadingAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOndownloadingAttribute();
		
		/// <summary>Member SetOndownloadingAttribute </summary>
		/// <param name='aOndownloading'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndownloadingAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOndownloading);
		
		/// <summary>Member GetOnprogressAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnprogressAttribute();
		
		/// <summary>Member SetOnprogressAttribute </summary>
		/// <param name='aOnprogress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnprogress);
		
		/// <summary>Member GetOnupdatereadyAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnupdatereadyAttribute();
		
		/// <summary>Member SetOnupdatereadyAttribute </summary>
		/// <param name='aOnupdateready'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnupdatereadyAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnupdateready);
		
		/// <summary>Member GetOncachedAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOncachedAttribute();
		
		/// <summary>Member SetOncachedAttribute </summary>
		/// <param name='aOncached'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncachedAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOncached);
		
		/// <summary>Member GetOnobsoleteAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnobsoleteAttribute();
		
		/// <summary>Member SetOnobsoleteAttribute </summary>
		/// <param name='aOnobsolete'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnobsoleteAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnobsolete);
	}
}
