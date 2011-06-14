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
// Generated by IDLImporter from file nsISHTransaction.idl
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
    /// The nsISHTransaction.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2EDF705F-D252-4971-9F09-71DD0F760DC6")]
	public interface nsISHTransaction
	{
		
		/// <summary>
        /// The nsISHEntry for the current transaction
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry GetSHEntryAttribute();
		
		/// <summary>
        /// The nsISHEntry for the current transaction
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSHEntryAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry);
		
		/// <summary>
        /// The parent of this transaction
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHTransaction GetPrevAttribute();
		
		/// <summary>
        /// The parent of this transaction
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrevAttribute([MarshalAs(UnmanagedType.Interface)] nsISHTransaction aPrev);
		
		/// <summary>
        /// The legitimate child of this transaction
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHTransaction GetNextAttribute();
		
		/// <summary>
        /// The legitimate child of this transaction
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNextAttribute([MarshalAs(UnmanagedType.Interface)] nsISHTransaction aNext);
		
		/// <summary>
        /// Specifies if this transaction should persist.  If not it will be replaced
        /// by new additions to the list.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPersistAttribute();
		
		/// <summary>
        /// Specifies if this transaction should persist.  If not it will be replaced
        /// by new additions to the list.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistAttribute([MarshalAs(UnmanagedType.Bool)] bool aPersist);
		
		/// <summary>
        /// Create a transaction with parent and History Entry
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create([MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry, [MarshalAs(UnmanagedType.Interface)] nsISHTransaction aPrev);
	}
}
