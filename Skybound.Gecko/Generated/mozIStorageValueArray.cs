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
// Generated by IDLImporter from file mozIStorageValueArray.idl
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
    /// mozIStorageValueArray wraps an array of SQL values, such as a single database
    /// row.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("07b5b93e-113c-4150-863c-d247b003a55d")]
	public interface mozIStorageValueArray
	{
		
		/// <summary>
        /// numEntries
        ///
        /// number of entries in the array (each corresponding to a column
        /// in the database row)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumEntriesAttribute();
		
		/// <summary>
        /// Returns the type of the value at the given column index;
        /// one of VALUE_TYPE_NULL, VALUE_TYPE_INTEGER, VALUE_TYPE_FLOAT,
        /// VALUE_TYPE_TEXT, VALUE_TYPE_BLOB.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTypeOfIndex(uint aIndex);
		
		/// <summary>
        /// Obtain a value for the given entry (column) index.
        /// Due to SQLite's type conversion rules, any of these are valid
        /// for any column regardless of the column's data type.  However,
        /// if the specific type matters, getTypeOfIndex should be used
        /// first to identify the column type, and then the appropriate
        /// get method should be called.
        ///
        /// If you ask for a string value for a NULL column, you will get an empty
        /// string with IsVoid set to distinguish it from an explicitly set empty
        /// string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetInt32(uint aIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetInt64(uint aIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDouble(uint aIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUTF8String(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetString(uint aIndex, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// data will be NULL if dataSize = 0
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBlob(uint aIndex, ref uint aDataSize, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref byte[] aData);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsNull(uint aIndex);
		
		/// <summary>
        /// Returns a shared string pointer
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetSharedUTF8String(uint aIndex, ref uint aLength);
		
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetSharedString(uint aIndex, ref uint aLength);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetSharedBlob(uint aIndex, ref uint aLength);
	}
	
	/// <summary>mozIStorageValueArrayConsts </summary>
	public class mozIStorageValueArrayConsts
	{
		
		// <summary>
        // These type values are returned by getTypeOfIndex
        // to indicate what type of value is present at
        // a given column.
        // </summary>
		public const long VALUE_TYPE_NULL = 0;
		
		// 
		public const long VALUE_TYPE_INTEGER = 1;
		
		// 
		public const long VALUE_TYPE_FLOAT = 2;
		
		// 
		public const long VALUE_TYPE_TEXT = 3;
		
		// 
		public const long VALUE_TYPE_BLOB = 4;
	}
}
