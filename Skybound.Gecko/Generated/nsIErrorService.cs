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
// Generated by IDLImporter from file nsIErrorService.idl
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
    /// nsIErrorService: This is an interim service that allows nsresult codes to be mapped to
    /// string bundles that can be used to look up error messages. String bundle keys can also
    /// be mapped.
    ///
    /// This service will eventually get replaced by extending xpidl to allow errors to be defined.
    /// (http://bugzilla.mozilla.org/show_bug.cgi?id=13423).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e72f94b2-5f85-11d4-9877-00c04fa0cf4a")]
	public interface nsIErrorService
	{
		
		/// <summary>
        /// Registers a string bundle URL for an error module. Error modules are obtained from
        /// nsresult code with NS_ERROR_GET_MODULE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterErrorStringBundle(short errorModule, [MarshalAs(UnmanagedType.LPStr)] string stringBundleURL);
		
		/// <summary>
        /// Registers a string bundle URL for an error module.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterErrorStringBundle(short errorModule);
		
		/// <summary>
        /// Retrieves a string bundle URL for an error module.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetErrorStringBundle(short errorModule);
		
		/// <summary>
        /// Registers a key in a string bundle for an nsresult error code. Only the code portion
        /// of the nsresult is used (obtained with NS_ERROR_GET_CODE) in this registration. The
        /// string bundle key is used to look up internationalized messages in the string bundle.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterErrorStringBundleKey(int error, [MarshalAs(UnmanagedType.LPStr)] string stringBundleKey);
		
		/// <summary>
        /// Unregisters a key in a string bundle for an nsresult error code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterErrorStringBundleKey(int error);
		
		/// <summary>
        /// Retrieves a key in a string bundle for an nsresult error code. If no key is registered
        /// for the specified nsresult's code (obtained with NS_ERROR_GET_CODE), then the stringified
        /// version of the nsresult code is returned.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetErrorStringBundleKey(int error);
	}
}
