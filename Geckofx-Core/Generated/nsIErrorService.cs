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
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
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
	[Guid("afe1f190-a3c2-11e3-a5e2-0800200c9a66")]
	public interface nsIErrorService
	{
		
		/// <summary>
        /// Registers a string bundle URL for an error module. Error modules are obtained from
        /// nsresult code with NS_ERROR_GET_MODULE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterErrorStringBundle(short errorModule, [MarshalAs(UnmanagedType.LPStr)] string stringBundleURL);
		
		/// <summary>
        /// Unregisters a string bundle URL for an error module.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterErrorStringBundle(short errorModule);
		
		/// <summary>
        /// Retrieves a string bundle URL for an error module.
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetErrorStringBundle(short errorModule);
	}
}
