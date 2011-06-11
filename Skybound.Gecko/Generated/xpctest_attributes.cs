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
// Generated by IDLImporter from file xpctest_attributes.idl
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
    /// This defines the interface for a test object.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1364941e-4462-11d3-82ee-0060b0eb596f")]
	public interface nsIXPCTestObjectReadOnly
	{
		
		/// <summary>
        /// This defines the interface for a test object.
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetStrReadOnlyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetBoolReadOnlyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetShortReadOnlyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetLongReadOnlyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetFloatReadOnlyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Char  GetCharReadOnlyAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetID();
	}
	
	/// <summary>nsIXPCTestObjectReadWrite </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3b9b1d38-491a-11d3-82ef-0060b0eb596f")]
	public interface nsIXPCTestObjectReadWrite
	{
		
		/// <summary>Member GetStringPropertyAttribute </summary>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  GetStringPropertyAttribute();
		
		/// <summary>Member SetStringPropertyAttribute </summary>
		/// <param name='aStringProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStringPropertyAttribute([MarshalAs(UnmanagedType.LPStr)] System.String  aStringProperty);
		
		/// <summary>Member GetBooleanPropertyAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetBooleanPropertyAttribute();
		
		/// <summary>Member SetBooleanPropertyAttribute </summary>
		/// <param name='aBooleanProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBooleanPropertyAttribute(System.Boolean  aBooleanProperty);
		
		/// <summary>Member GetShortPropertyAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetShortPropertyAttribute();
		
		/// <summary>Member SetShortPropertyAttribute </summary>
		/// <param name='aShortProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShortPropertyAttribute(short aShortProperty);
		
		/// <summary>Member GetLongPropertyAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetLongPropertyAttribute();
		
		/// <summary>Member SetLongPropertyAttribute </summary>
		/// <param name='aLongProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLongPropertyAttribute(System.Int32  aLongProperty);
		
		/// <summary>Member GetFloatPropertyAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetFloatPropertyAttribute();
		
		/// <summary>Member SetFloatPropertyAttribute </summary>
		/// <param name='aFloatProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFloatPropertyAttribute(double aFloatProperty);
		
		/// <summary>Member GetCharPropertyAttribute </summary>
		/// <returns>A System.Char </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Char  GetCharPropertyAttribute();
		
		/// <summary>Member SetCharPropertyAttribute </summary>
		/// <param name='aCharProperty'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharPropertyAttribute(System.Char  aCharProperty);
	}
}
