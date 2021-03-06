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
// Generated by IDLImporter from file nsIWeakCryptoOverride.idl
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
    /// This represents the fallback whitelist for
    /// weak crypto servers such as RC4-only.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("27b4d3df-8f15-4eb4-a35f-474e911b61e7")]
	public interface nsIWeakCryptoOverride
	{
		
		/// <summary>
        /// Add a weak crypto override for the given hostname.
        /// Main thread only.
        ///
        /// @param aHostName The host (punycode) this mapping belongs to
        /// @param aPrivate The override info will used for the private browsing
        /// session and no information will be written to the disk.
        /// @param aTemporary The override info will not persist between sessions.
        /// Ignored if aPrivate is true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWeakCryptoOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, [MarshalAs(UnmanagedType.U1)] bool aPrivate, [MarshalAs(UnmanagedType.U1)] bool aTemporary);
		
		/// <summary>
        /// Remove a weak crypto override for the given hostname:port.
        /// Main thread only.
        ///
        /// @param aHostName The host (punycode) whose entry should be cleared.
        /// @param aPort The port whose entry should be cleared.
        /// @param aPrivate The override info will used for the private browsing
        /// session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWeakCryptoOverride([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHostName, int aPort, [MarshalAs(UnmanagedType.U1)] bool aPrivate);
	}
}
