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
// Generated by IDLImporter from file nsIServiceManager.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>
    /// The nsIServiceManager manager interface provides a means to obtain
    /// global services in an application. The service manager depends on the
    /// repository to find and instantiate factories to obtain services.
    ///
    /// Users of the service manager must first obtain a pointer to the global
    /// service manager by calling NS_GetServiceManager. After that,
    /// they can request specific services by calling GetService. When they are
    /// finished they can NS_RELEASE() the service as usual.
    ///
    /// A user of a service may keep references to particular services indefinitely
    /// and only must call Release when it shuts down.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8bb35ed9-e332-462d-9155-4a002ab5c958")]
	public interface nsIServiceManager
	{
		
		/// <summary>
        /// getServiceByContractID
        ///
        /// Returns the instance that implements aClass or aContractID and the
        /// interface aIID.  This may result in the instance being created.
        ///
        /// @param aClass or aContractID : aClass or aContractID of object
        /// instance requested
        /// @param aIID : IID of interface requested
        /// @param result : resulting service
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetService(ref System.Guid aClass, ref System.Guid aIID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetServiceByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref System.Guid aIID);
		
		/// <summary>
        /// isServiceInstantiated
        ///
        /// isServiceInstantiated will return a true if the service has already
        /// been created, otherwise false
        ///
        /// @param aClass or aContractID : aClass or aContractID of object
        /// instance requested
        /// @param aIID : IID of interface requested
        /// @param aIID : IID of interface requested
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsServiceInstantiated(ref System.Guid aClass, ref System.Guid aIID);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsServiceInstantiatedByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref System.Guid aIID);
	}
}
