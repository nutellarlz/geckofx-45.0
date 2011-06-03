// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIResumableChannel.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIResumableChannel.idl
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
	
	
	/// <summary>nsIResumableChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4ad136fa-83af-4a22-a76e-503642c0f4a8")]
	public interface nsIResumableChannel
	{
		
		/// <summary>Member ResumeAt </summary>
		/// <param name='startPos'> </param>
		/// <param name='entityID'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeAt(System.UInt32  startPos, [MarshalAs(UnmanagedType.LPStruct)] nsAString  entityID);
		
		/// <summary>Member GetEntityIDAttribute </summary>
		/// <param name='aEntityID'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEntityIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aEntityID);
	}
}