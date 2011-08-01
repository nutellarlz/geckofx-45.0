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
// Generated by IDLImporter from file SessionStore.idl
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
    /// nsISessionStore keeps track of the current browsing state.
    ///
    /// The nsISessionStore API operates mostly on browser windows and the browser
    /// tabs contained in them.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("766a09c1-d21b-4bf8-9fe3-8b34b716251a")]
	public interface nsISessionStore
	{
		
		/// <summary>
        /// Get the current browsing state.
        /// @returns a JSON string representing the session state.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBrowserState([MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// Get the number of restore-able tabs for a browser window
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetClosedTabCount([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);
		
		/// <summary>
        /// Get closed tab data
        ///
        /// @param aWindow is the browser window for which to get closed tab data
        /// @returns a JSON string representing the list of closed tabs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClosedTabData([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// @param aWindow is the browser window to reopen a closed tab in.
        /// @param aIndex  is the index of the tab to be restored (FIFO ordered).
        /// @returns a reference to the reopened tab.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode UndoCloseTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, uint aIndex);
		
		/// <summary>
        /// @param aWindow is the browser window associated with the closed tab.
        /// @param aIndex  is the index of the closed tab to be removed (FIFO ordered).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ForgetClosedTab([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow, uint aIndex);
		
		/// <summary>
        /// @param aTab is the browser tab to get the value for.
        /// @param aKey is the value's name.
        ///
        /// @returns A string value or an empty string if none is set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// @param aTab         is the browser tab to set the value for.
        /// @param aKey         is the value's name.
        /// @param aStringValue is the value itself (use JSON.stringify/parse before setting JS objects).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey, [MarshalAs(UnmanagedType.LPStruct)] nsAString aStringValue);
		
		/// <summary>
        /// @param aTab is the browser tab to get the value for.
        /// @param aKey is the value's name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteTabValue([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aTab, [MarshalAs(UnmanagedType.LPStruct)] nsAString aKey);
		
		/// <summary>
        /// @returns A boolean indicating we should restore previous browser session
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ShouldRestore();
		
		/// <summary>
        /// Restores the previous browser session using a fast, lightweight strategy
        /// @param aBringToFront should a restored tab be brought to the foreground?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RestoreLastSession([MarshalAs(UnmanagedType.Bool)] bool aBringToFront);
	}
}
