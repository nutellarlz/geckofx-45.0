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
// Generated by IDLImporter from file nsISystemMessageGlue.idl
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
    /// Implemented by the contract id @mozilla.org/dom/messages/system-message-glue;1
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b5d98286-e7cc-11e3-92fb-74d02b97e723")]
	public interface nsISystemMessageGlue
	{
		
		/// <summary>
        ///Notify the system app to open the target app.
        ///
        /// @param pageURL     The URL of the page that will be opened.
        /// @param manifestURL The webapp's manifest URL.
        /// @param type        The message type.
        /// @param target      The target which the message is associated with.
        /// @param showApp     This flag indicates the app must be brought to the
        /// foreground.
        /// @param onlyShowApp This flag indicates the app must be *only* brought to
        /// the foreground without loading to handle messages.
        /// @param extra       Extra opaque info to pass around for opening the page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenApp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase pageURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase manifestURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, ref Gecko.JsVal target, [MarshalAs(UnmanagedType.U1)] bool showApp, [MarshalAs(UnmanagedType.U1)] bool onlyShowApp, ref Gecko.JsVal extra);
	}
}
