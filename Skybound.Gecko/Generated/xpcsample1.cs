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
// Generated by IDLImporter from file xpcsample1.idl
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
    /// forward declare the below interfaces for clarity
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6bd0c120-c216-11d3-98c9-006008962422")]
	public interface nsIXPCSample_ClassA
	{
		
		/// <summary>
        /// forward declare the below interfaces for clarity
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSomeValueAttribute();
		
		/// <summary>
        /// forward declare the below interfaces for clarity
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSomeValueAttribute(System.Int32  aSomeValue);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCSample_ClassB  GetBAttribute();
	}
	
	/// <summary>nsIXPCSample_ClassB </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c9c7bac0-c216-11d3-98c9-006008962422")]
	public interface nsIXPCSample_ClassB
	{
		
		/// <summary>Member GetSomeValueAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSomeValueAttribute();
		
		/// <summary>Member SetSomeValueAttribute </summary>
		/// <param name='aSomeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSomeValueAttribute(System.Int32  aSomeValue);
		
		/// <summary>Member GetCAttribute </summary>
		/// <returns>A nsIXPCSample_ClassC </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXPCSample_ClassC  GetCAttribute();
	}
	
	/// <summary>nsIXPCSample_ClassC </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("df7bd080-c216-11d3-98c9-006008962422")]
	public interface nsIXPCSample_ClassC
	{
		
		/// <summary>Member GetSomeValueAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetSomeValueAttribute();
		
		/// <summary>Member SetSomeValueAttribute </summary>
		/// <param name='aSomeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSomeValueAttribute(System.Int32  aSomeValue);
	}
	
	/// <summary>
    /// activity from within an xpcom component.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("15794370-c217-11d3-98c9-006008962422")]
	public interface nsIXPCSample_HookerUpper
	{
		
		/// <summary>
        /// activity from within an xpcom component.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateSampleObjectAtGlobalScope([MarshalAs(UnmanagedType.LPStr)] System.String  name, System.Int32  value);
	}
}
