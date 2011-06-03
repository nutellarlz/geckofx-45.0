// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMGlobalPropertyInitializer.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMGlobalPropertyInitializer.idl
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
	
	
	/// <summary>nsIDOMGlobalPropertyInitializer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6368a821-d3e2-4cbd-9699-5a8ba569e2f3")]
	public interface nsIDOMGlobalPropertyInitializer
	{
		
		/// <summary>Member Init </summary>
		/// <param name='window'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  window);
	}
}