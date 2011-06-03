// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISocketTransportService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISocketTransportService.idl
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
	
	
	/// <summary>nsISocketTransportService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("185B3A5D-8729-436D-9693-7BDCCB9C2216")]
	public interface nsISocketTransportService
	{
		
		/// <summary>Member CreateTransport </summary>
		/// <param name='aSocketTypes'> </param>
		/// <param name='aTypeCount'> </param>
		/// <param name='aHost'> </param>
		/// <param name='aPort'> </param>
		/// <param name='aProxyInfo'> </param>
		/// <returns>A nsISocketTransport</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISocketTransport CreateTransport([MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)] System.String  aSocketTypes, System.UInt32  aTypeCount, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aHost, System.Int32  aPort, [MarshalAs(UnmanagedType.Interface)] nsIProxyInfo  aProxyInfo);
		
		/// <summary>Member AttachSocket </summary>
		/// <param name='aFd'> </param>
		/// <param name='aHandler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AttachSocket(System.IntPtr aFd, System.IntPtr aHandler);
		
		/// <summary>Member NotifyWhenCanAttachSocket </summary>
		/// <param name='aEvent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyWhenCanAttachSocket([MarshalAs(UnmanagedType.Interface)] nsIRunnable  aEvent);
	}
}