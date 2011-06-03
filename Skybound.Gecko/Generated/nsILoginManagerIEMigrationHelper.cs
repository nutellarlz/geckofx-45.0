// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsILoginManagerIEMigrationHelper.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsILoginManagerIEMigrationHelper.idl
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
	
	
	/// <summary>nsILoginManagerIEMigrationHelper </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8a59ea3d-b8d0-48af-a3e2-63e27a02cde7")]
	public interface nsILoginManagerIEMigrationHelper
	{
		
		/// <summary>Member MigrateAndAddLogin </summary>
		/// <param name='aLogin'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MigrateAndAddLogin([MarshalAs(UnmanagedType.Interface)] nsILoginInfo  aLogin);
	}
}