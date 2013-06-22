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
// Generated by IDLImporter from file nsIDownloadManagerUI.idl
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
	[Guid("0c76d4cf-0b06-4c1a-9bea-520c7bbdba99")]
	public interface nsIDownloadManagerUI
	{
		
		/// <summary>
        /// Shows the Download Manager's UI to the user.
        ///
        /// @param [optional] aWindowContext
        /// The parent window context to show the UI.
        /// @param [optional] aDownload
        /// The download to be preselected upon opening.
        /// @param [optional] aReason
        /// The reason to show the download manager's UI.  This defaults to
        /// REASON_USER_INTERACTED, and should be one of the previously listed
        /// constants.
        /// @param [optional] aUsePrivateUI
        /// Pass true as this argument to hint to the implementation that it
        /// should only display private downloads in the UI, if possible.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Show([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext, [MarshalAs(UnmanagedType.Interface)] nsIDownload aDownload, short aReason, [MarshalAs(UnmanagedType.U1)] bool aUsePrivateUI);
		
		/// <summary>
        /// Indicates if the UI is visible or not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibleAttribute();
		
		/// <summary>
        /// Brings attention to the UI if it is already visible
        ///
        /// @throws NS_ERROR_UNEXPECTED if the UI is not visible.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAttention();
	}
	
	/// <summary>nsIDownloadManagerUIConsts </summary>
	public class nsIDownloadManagerUIConsts
	{
		
		// <summary>
        // The reason that should be passed when the user requests to show the
        // download manager's UI.
        // </summary>
		public const int REASON_USER_INTERACTED = 0;
		
		// <summary>
        // The reason that should be passed to the show method when we are displaying
        // the UI because a new download is being added to it.
        // </summary>
		public const int REASON_NEW_DOWNLOAD = 1;
	}
}
