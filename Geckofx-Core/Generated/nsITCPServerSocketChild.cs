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
// Generated by IDLImporter from file nsITCPServerSocketChild.idl
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
    /// Interface to allow the content process server socket to reach the IPC bridge.
    /// It is used in the server socket implementation on the child side.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("41a77ec8-fd86-409e-aea9-af2ca407ef8e")]
	public interface nsITCPServerSocketChild
	{
		
		/// <summary>
        /// Tell the chrome process to listen on the port with the given parameters.
        ///
        /// @param serverSocket
        /// The server socket generated in the listen of nsIDOMTCPSocket
        /// on the child side.
        /// @param port
        /// The port of the server socket.
        /// @param backlog
        /// The maximum length the queue of pending connections may grow to.
        /// @param binaryType
        /// "arraybuffer" to use UInt8 array instances or "string" to use String.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Listen([MarshalAs(UnmanagedType.Interface)] nsITCPServerSocketInternal serverSocket, ushort port, ushort backlog, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase binaryType, System.IntPtr jsContext);
		
		/// <summary>
        /// Tell the chrome process to close the server socket.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
	}
}
