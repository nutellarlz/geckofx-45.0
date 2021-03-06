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
// Generated by IDLImporter from file nsIVoicemailService.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6a8b0133-960d-409d-88cd-583239e45f9f")]
	public interface nsIVoicemailListener
	{
		
		/// <summary>
        /// Called when a voicemail status (hasMessages, messageCount, returnNumber,
        /// returnMessage) changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyStatusChanged([MarshalAs(UnmanagedType.Interface)] nsIVoicemailProvider provider);
		
		/// <summary>
        /// Called when a voicemail info (number, displayName) changed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyInfoChanged([MarshalAs(UnmanagedType.Interface)] nsIVoicemailProvider provider);
	}
	
	/// <summary>
    /// XPCOM component (in the content process) that provides the voicemail
    /// information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8ffd16c7-a614-4c4a-81f0-2a95e807152d")]
	public interface nsIVoicemailService
	{
		
		/// <summary>
        /// XPCOM component (in the content process) that provides the voicemail
        /// information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumItemsAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVoicemailProvider GetItemByServiceId(uint serviceId);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVoicemailProvider GetDefaultItem();
		
		/// <summary>
        /// Called when any one who is interested in receiving unsolicited messages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterListener([MarshalAs(UnmanagedType.Interface)] nsIVoicemailListener listener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterListener([MarshalAs(UnmanagedType.Interface)] nsIVoicemailListener listener);
	}
	
	/// <summary>nsIVoicemailProvider </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a0bc19a2-3216-4f3f-89d3-8976a48cb829")]
	public interface nsIVoicemailProvider
	{
		
		/// <summary>Member GetServiceIdAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetServiceIdAttribute();
		
		/// <summary>
        /// Voicemail center number. When changed, |notifyInfoChanged| of registered
        /// nsIVoicemailListener instances are called.
        ///
        /// Default: null
        ///
        /// @see 3GPP TS 31.102 subclause 4.2.63 "EFmwis (Message Waiting Indication Status)"
        /// @see 3GPP TS 51.011 subclause 10.3.45 "EFmwis (Message Waiting Indication Status)"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNumberAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aNumber);
		
		/// <summary>
        /// Voicemail center display name. When changed, |notifyInfoChanged| of
        /// registered nsIVoicemailListener instances are called.
        ///
        /// Default: null
        ///
        /// @see 3GPP TS 31.102 subclause 4.2.63 "EFmwis (Message Waiting Indication Status)"
        /// @see 3GPP TS 51.011 subclause 10.3.45 "EFmwis (Message Waiting Indication Status)"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplayNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aDisplayName);
		
		/// <summary>
        /// Whether or not there are messages waiting in the voicemail box. When
        /// changed, |notifyStatusChanged| of registered nsIVoicemailListener instances
        /// are called.
        ///
        /// Default: false
        ///
        /// @see 3GPP TS 23.038 chapter 4 "SMS Data Coding Scheme"
        /// @see 3GPP TS 23.040 subclause 9.2.3.24.2 "Special SMS Message Indication"
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasMessagesAttribute();
		
		/// <summary>
        /// When #hasMessages is true, #messageCount should be a positive number for
        /// the messages waiting, or -1 if the exact number is not available. When
        /// changed, |notifyStatusChanged| of registered nsIVoicemailListener instances
        /// are called.
        ///
        /// Default: 0
        ///
        /// @see 3GPP TS 23.040 subclause 9.2.3.24.2 "Special SMS Message Indication"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMessageCountAttribute();
		
		/// <summary>
        /// A Return Call Message indicates to the MS to inform the user that a call
        /// (e.g. a telephone call) can be established to the address specified within
        /// the #returnNumber. The #returnMessage (if present) gives displayable
        /// information (e.g. the number of waiting voice messages).
        ///
        /// When #hasMessages is true this may contain a non-null string as the phone
        /// number of a Return Call Message. When changed, |notifyStatusChanged| of
        /// registered nsIVoicemailListener instances are called.
        ///
        /// Default: null
        ///
        /// @see 3GPP TS 23.040 subclause 9.2.3.9 "TPProtocolIdentifier (TPPID)"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReturnNumberAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReturnNumber);
		
		/// <summary>
        /// When #hasMessages is true this may contain a non-null string as the
        /// notification message of a Return Call Message. When changed,
        /// |notifyStatusChanged| of registered nsIVoicemailListener instances are
        /// called.
        ///
        /// Default: null
        ///
        /// @see 3GPP TS 23.040 subclause 9.2.3.9 "TPProtocolIdentifier (TPPID)"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReturnMessageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aReturnMessage);
	}
}
