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
// Generated by IDLImporter from file nsIFileView.idl
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
	
	
	/// <summary>nsIFileView </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("60b320d2-1dd2-11b2-bd73-dc3575f78ddd")]
	public interface nsIFileView
	{
		
		/// <summary>Member GetShowHiddenFilesAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowHiddenFilesAttribute();
		
		/// <summary>Member SetShowHiddenFilesAttribute </summary>
		/// <param name='aShowHiddenFiles'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowHiddenFilesAttribute([MarshalAs(UnmanagedType.U1)] bool aShowHiddenFiles);
		
		/// <summary>Member GetShowOnlyDirectoriesAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowOnlyDirectoriesAttribute();
		
		/// <summary>Member SetShowOnlyDirectoriesAttribute </summary>
		/// <param name='aShowOnlyDirectories'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowOnlyDirectoriesAttribute([MarshalAs(UnmanagedType.U1)] bool aShowOnlyDirectories);
		
		/// <summary>Member GetSortTypeAttribute </summary>
		/// <returns>A System.Int16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetSortTypeAttribute();
		
		/// <summary>Member GetReverseSortAttribute </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetReverseSortAttribute();
		
		/// <summary>Member Sort </summary>
		/// <param name='sortType'> </param>
		/// <param name='reverseSort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Sort(short sortType, [MarshalAs(UnmanagedType.U1)] bool reverseSort);
		
		/// <summary>Member SetDirectory </summary>
		/// <param name='directory'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDirectory([MarshalAs(UnmanagedType.Interface)] nsIFile directory);
		
		/// <summary>Member SetFilter </summary>
		/// <param name='filterString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilter([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase filterString);
		
		/// <summary>Member GetSelectedFilesAttribute </summary>
		/// <returns>A nsIArray</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetSelectedFilesAttribute();
	}
	
	/// <summary>nsIFileViewConsts </summary>
	public class nsIFileViewConsts
	{
		
		// 
		public const int sortName = 0;
		
		// 
		public const int sortSize = 1;
		
		// 
		public const int sortDate = 2;
	}
}
