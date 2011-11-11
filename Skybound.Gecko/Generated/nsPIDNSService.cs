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
// Generated by IDLImporter from file nsPIDNSService.idl
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
    /// This is a private interface used by the internals of the networking library.
    /// It will never be frozen.  Do not use it in external code.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a26c5b45-7707-4412-bbc1-2462b890848d")]
	public interface nsPIDNSService : nsIDNSService
	{
		
		/// <summary>
        /// kicks off an asynchronous host lookup.
        ///
        /// @param aHostName
        /// the hostname or IP-address-literal to resolve.
        /// @param aFlags
        /// a bitwise OR of the RESOLVE_ prefixed constants defined below.
        /// @param aListener
        /// the listener to be notified when the result is available.
        /// @param aListenerTarget
        /// optional parameter (may be null).  if non-null, this parameter
        /// specifies the nsIEventTarget of the thread on which the
        /// listener's onLookupComplete should be called.  however, if this
        /// parameter is null, then onLookupComplete will be called on an
        /// unspecified thread (possibly recursively).
        ///
        /// @return An object that can be used to cancel the host lookup.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsICancelable AsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);
		
		/// <summary>
        /// called to synchronously resolve a hostname.  warning this method may
        /// block the calling thread for a long period of time.  it is extremely
        /// unwise to call this function on the UI thread of an application.
        ///
        /// @param aHostName
        /// the hostname or IP-address-literal to resolve.
        /// @param aFlags
        /// a bitwise OR of the RESOLVE_ prefixed constants defined below.
        ///
        /// @return DNS record corresponding to the given hostname.
        /// @throws NS_ERROR_UNKNOWN_HOST if host could not be resolved.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDNSRecord Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aHostName, uint aFlags);
		
		/// <summary>
        /// @return the hostname of the operating system.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMyHostNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMyHostName);
		
		/// <summary>
        /// called to initialize the DNS service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		/// <summary>
        /// called to shutdown the DNS service.  any pending asynchronous
        /// requests will be canceled, and the local cache of DNS records
        /// will be cleared.  NOTE: the operating system may still have
        /// its own cache of DNS records, which would be unaffected by
        /// this method.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Shutdown();
	}
}
