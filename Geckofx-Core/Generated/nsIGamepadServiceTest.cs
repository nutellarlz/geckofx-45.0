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
// Generated by IDLImporter from file nsIGamepadServiceTest.idl
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
    /// This interface is intended only for use in tests.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c03ec4ed-8a7e-40e7-99da-c609f1760d0c")]
	public interface nsIGamepadServiceTest
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint AddGamepad([MarshalAs(UnmanagedType.LPStr)] string id, uint mapping, uint numButtons, uint numAxes);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveGamepad(uint index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NewButtonEvent(uint index, uint button, [MarshalAs(UnmanagedType.U1)] bool pressed);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NewButtonValueEvent(uint index, uint button, [MarshalAs(UnmanagedType.U1)] bool pressed, double value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NewAxisMoveEvent(uint index, uint axis, double value);
	}
	
	/// <summary>nsIGamepadServiceTestConsts </summary>
	public class nsIGamepadServiceTestConsts
	{
		
		// <summary>
        // This interface is intended only for use in tests.
        // </summary>
		public const ulong NO_MAPPING = 0;
		
		// 
		public const ulong STANDARD_MAPPING = 1;
	}
}
