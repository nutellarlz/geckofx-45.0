// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIFontEnumerator.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIFontEnumerator.idl
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
	
	
	/// <summary>nsIFontEnumerator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("924d98d9-3518-4cb4-8708-c74fe8e3ec3c")]
	public interface nsIFontEnumerator
	{
		
		/// <summary>Member EnumerateAllFonts </summary>
		/// <param name='aCount'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string EnumerateAllFonts(out System.UInt32  aCount);
		
		/// <summary>Member EnumerateFonts </summary>
		/// <param name='aLangGroup'> </param>
		/// <param name='aGeneric'> </param>
		/// <param name='aCount'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=2)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string EnumerateFonts([MarshalAs(UnmanagedType.LPStr)] System.String  aLangGroup, [MarshalAs(UnmanagedType.LPStr)] System.String  aGeneric, out System.UInt32  aCount);
		
		/// <summary>Member HaveFontFor </summary>
		/// <param name='aLangGroup'> </param>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  HaveFontFor([MarshalAs(UnmanagedType.LPStr)] System.String  aLangGroup);
		
		/// <summary>Member GetDefaultFont </summary>
		/// <param name='aLangGroup'> </param>
		/// <param name='aGeneric'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDefaultFont([MarshalAs(UnmanagedType.LPStr)] System.String  aLangGroup, [MarshalAs(UnmanagedType.LPStr)] System.String  aGeneric);
		
		/// <summary>Member UpdateFontList </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool UpdateFontList();
		
		/// <summary>Member GetStandardFamilyName </summary>
		/// <param name='aName'> </param>
		/// <returns>A System.String</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetStandardFamilyName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName);
	}
}