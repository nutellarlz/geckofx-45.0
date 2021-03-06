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
// Generated by IDLImporter from file nsISystemMessagesInternal.idl
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
    /// Implemented by the contract id @mozilla.org/system-message-internal;1
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("59b6beda-f911-4d47-a296-8c81e6abcfb9")]
	public interface nsISystemMessagesInternal
	{
		
		/// <summary>
        /// Allow any internal user to send a message of a given type to a given page
        /// of an app. The message will be sent to all the registered pages of the app
        /// when |pageURI| is not specified.
        /// @param type        The type of the message to be sent.
        /// @param message     The message payload.
        /// @param pageURI     The URI of the page that will be opened. Nullable.
        /// @param manifestURI The webapp's manifest URI.
        /// @param extra       Extra opaque information that will be passed around in the observer
        /// notification to open the page.
        /// returns a Promise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports SendMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, ref Gecko.JsVal message, [MarshalAs(UnmanagedType.Interface)] nsIURI pageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI manifestURI, ref Gecko.JsVal extra);
		
		/// <summary>
        /// Allow any internal user to broadcast a message of a given type.
        /// The application that registers the message will be launched.
        /// @param type        The type of the message to be sent.
        /// @param message     The message payload.
        /// @param extra       Extra opaque information that will be passed around in the observer
        /// notification to open the page.
        /// returns a Promise
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports BroadcastMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, ref Gecko.JsVal message, ref Gecko.JsVal extra);
		
		/// <summary>
        /// Registration of a page that wants to be notified of a message type.
        /// @param type          The message type.
        /// @param pageURI       The URI of the page that will be opened.
        /// @param manifestURI   The webapp's manifest URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, [MarshalAs(UnmanagedType.Interface)] nsIURI pageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI manifestURI);
		
		/// <summary>
        /// Refresh the system message cache in a content process.
        /// @param manifestURI The webapp's manifest URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RefreshCache([MarshalAs(UnmanagedType.Interface)] nsIMessageSender childMM, [MarshalAs(UnmanagedType.Interface)] nsIURI manifestURI);
	}
	
	/// <summary>nsISystemMessagesWrapper </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("002f0e82-91f0-41de-ad43-569a2b9d12df")]
	public interface nsISystemMessagesWrapper
	{
		
		/// <summary>
        /// Wrap a message and gives back any kind of object.
        /// @param message  The json blob to wrap.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal WrapMessage(ref Gecko.JsVal message, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
	}
	
	/// <summary>
    /// Implements an interface to allow specific message types to
    /// configure some behaviors
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("31b78730-21c6-11e4-8c21-0800200c9a66")]
	public interface nsISystemMessagesConfigurator
	{
		
		/// <summary>
        /// Will be true if this type of system messages assumes/requires
        /// that the app will be brought to the front always.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMustShowRunningAppAttribute();
		
		/// <summary>
        /// A broadcast filter for a specific message type.
        ///
        /// @return Promise which resolves with |true| or |false| to indicate if
        /// we want to dispatch this message.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal ShouldDispatch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase manifestURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase pageURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, ref Gecko.JsVal message, ref Gecko.JsVal extra);
	}
}
