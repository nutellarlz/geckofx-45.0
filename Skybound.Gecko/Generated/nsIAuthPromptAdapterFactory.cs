// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIAuthPromptAdapterFactory.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIAuthPromptAdapterFactory.idl
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
	
	
	/// <summary>nsIAuthPromptAdapterFactory </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("60e46383-bb9a-4860-8962-80d9c5c05ddc")]
	public interface nsIAuthPromptAdapterFactory
	{
		
		/// <summary>Member CreateAdapter </summary>
		/// <param name='aPrompt'> </param>
		/// <returns>A nsIAuthPrompt2</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAuthPrompt2 CreateAdapter([MarshalAs(UnmanagedType.Interface)] nsIAuthPrompt  aPrompt);
	}
}