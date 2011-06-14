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
// Generated by IDLImporter from file nsIDOMStorageManager.idl
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
	
	
	/// <summary>nsIDOMStorageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fd91ec36-7da8-43bb-b8f2-4b57a862a467")]
	public interface nsIDOMStorageManager
	{
		
		/// <summary>
        /// Return the amount of disk space used by a domain.  Usage is checked
        /// against the domain of the page that set the key (the owner domain), not
        /// the domain of the storage object.
        ///
        /// @param aOwnerDomain The domain to check.
        /// @returns the space usage of the domain, in bytes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetUsage([MarshalAs(UnmanagedType.LPStruct)] nsAString aOwnerDomain);
		
		/// <summary>
        /// Clear keys owned by offline applications.  All data owned by a domain
        /// with the "offline-app" permission will be removed from the database.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearOfflineApps();
		
		/// <summary>
        /// Returns instance of localStorage object for aURI's origin.
        /// This method ensures there is always only a single instance
        /// for a single origin.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStorage GetLocalStorageForPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.LPStruct)] nsAString aDocumentURI);
	}
}
