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
// Generated by IDLImporter from file nsICommandParams.idl
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
    /// nsICommandParams is used to pass parameters to commands executed
    /// via nsICommandManager, and to get command state.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("83f892cf-7ed3-490e-967a-62640f3158e1")]
	public interface nsICommandParams
	{
		
		/// <summary>
        /// getValueType
        ///
        /// Get the type of a specified parameter
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetValueType([MarshalAs(UnmanagedType.LPStr)] string name);
		
		/// <summary>
        /// get_Value
        ///
        /// Get the value of a specified parameter. Will return
        /// an error if the parameter does not exist, or if the value
        /// is of the wrong type (no coercion is performed for you).
        ///
        /// nsISupports values can contain any XPCOM interface,
        /// as documented for the command. It is permissible
        /// for it to contain nsICommandParams, but not *this*
        /// one (i.e. self-containing is not allowed).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBooleanValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLongValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDoubleValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStringValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetCStringValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetISupportsValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		/// <summary>
        /// set_Value
        ///
        /// Set the value of a specified parameter (thus creating
        /// an entry for it).
        ///
        /// nsISupports values can contain any XPCOM interface,
        /// as documented for the command. It is permissible
        /// for it to contain nsICommandParams, but not *this*
        /// one (i.e. self-containing is not allowed).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBooleanValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.U1)] bool value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLongValue([MarshalAs(UnmanagedType.LPStr)] string name, int value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDoubleValue([MarshalAs(UnmanagedType.LPStr)] string name, double value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStringValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCStringValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetISupportsValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.Interface)] nsISupports value);
		
		/// <summary>
        /// removeValue
        ///
        /// Remove the specified parameter from the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		/// <summary>
        /// Enumeration methods
        ///
        /// Use these to enumerate over the contents of a parameter
        /// list. For each name that getNext() returns, use
        /// getValueType() and then getMumbleValue to get its
        /// value.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMoreElements();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void First();
		
		/// <summary>
        /// GetNext()
        ///
        /// @return string pointer that will be allocated and is up
        /// to the caller to free
        /// </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetNext();
	}
	
	/// <summary>nsICommandParamsConsts </summary>
	public class nsICommandParamsConsts
	{
		
		// <summary>
        // List of primitive types for parameter values.
        // </summary>
		public const int eNoType = 0;
		
		// <summary>
        //Only used for sanity checking </summary>
		public const int eBooleanType = 1;
		
		// 
		public const int eLongType = 2;
		
		// 
		public const int eDoubleType = 3;
		
		// 
		public const int eWStringType = 4;
		
		// 
		public const int eISupportsType = 5;
		
		// 
		public const int eStringType = 6;
	}
}
