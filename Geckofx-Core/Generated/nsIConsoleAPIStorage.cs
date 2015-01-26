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
// Generated by IDLImporter from file nsIConsoleAPIStorage.idl
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
	[Guid("6701600a-17ca-417e-98f9-4ceb175dd15d")]
	public interface nsIConsoleAPIStorage
	{
		
		/// <summary>
        /// Get the events array by inner window ID or all events from all windows.
        ///
        /// @param string [aId]
        /// Optional, the inner window ID for which you want to get the array of
        /// cached events.
        /// @returns array
        /// The array of cached events for the given window. If no |aId| is
        /// given this function returns all of the cached events, from any
        /// window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetEvents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
		
		/// <summary>
        /// Record an event associated with the given window ID.
        ///
        /// @param string aId
        /// The ID of the inner window for which the event occurred or "jsm" for
        /// messages logged from JavaScript modules..
        /// @param object aEvent
        /// A JavaScript object you want to store.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RecordEvent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId, Gecko.JsVal aEvent);
		
		/// <summary>
        /// Clear storage data for the given window.
        ///
        /// @param string [aId]
        /// Optional, the inner window ID for which you want to clear the
        /// messages. If this is not specified all of the cached messages are
        /// cleared, from all window objects.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearEvents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
	}
}
