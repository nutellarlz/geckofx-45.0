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
// Generated by IDLImporter from file nsIIDBObjectStore.idl
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
	
	
	/// <summary>nsIIDBIndexParameters </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("450e02fd-a87a-47d4-beaf-321417dad781")]
	public interface nsIIDBIndexParameters
	{
		
		/// <summary>Member GetUniqueAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUniqueAttribute();
		
		/// <summary>Member SetUniqueAttribute </summary>
		/// <param name='aUnique'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUniqueAttribute([MarshalAs(UnmanagedType.U1)] bool aUnique);
		
		/// <summary>Member GetMultiEntryAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMultiEntryAttribute();
		
		/// <summary>Member SetMultiEntryAttribute </summary>
		/// <param name='aMultiEntry'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMultiEntryAttribute([MarshalAs(UnmanagedType.U1)] bool aMultiEntry);
	}
	
	/// <summary>
    /// nsIIDBObjectStore interface.  See
    /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-nsIIDBObjectStore
    /// for more information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0d308ea-b804-4962-918a-28ec0aa4e42b")]
	public interface nsIIDBObjectStore
	{
		
		/// <summary>
        /// nsIIDBObjectStore interface.  See
        /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-nsIIDBObjectStore
        /// for more information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetKeyPathAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIndexNamesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBTransaction GetTransactionAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAutoIncrementAttribute();
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == value for key
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Get(Gecko.JsVal key, System.IntPtr jsContext);
		
		/// <summary>
        ///unlimited </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetAll(Gecko.JsVal key, uint limit, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///undefined </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Add(Gecko.JsVal value, Gecko.JsVal key, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///undefined </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Put(Gecko.JsVal value, Gecko.JsVal key, System.IntPtr jsContext, int argc);
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == null
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Delete(Gecko.JsVal key, System.IntPtr jsContext);
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == null
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Clear();
		
		/// <summary>
        ///NEXT </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest OpenCursor(Gecko.JsVal range, ushort direction, System.IntPtr jsContext, int argc);
		
		/// <summary>
        ///none </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBIndex CreateIndex([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, Gecko.JsVal keyPath, Gecko.JsVal options, System.IntPtr jsContext);
		
		/// <summary>
        /// Returns object immediately
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBIndex Index([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteIndex([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        /// Accepts null, a key value, or a nsIIDBKeyRange object.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Count(Gecko.JsVal key, System.IntPtr jsContext, int argc);
	}
}
