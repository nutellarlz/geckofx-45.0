// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISAXXMLReader.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISAXXMLReader.idl
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
	
	
	/// <summary>nsISAXXMLReader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5556997e-d816-4218-8b54-803d4261206e")]
	public interface nsISAXXMLReader : nsIStreamListener
	{
		
		/// <summary>Member OnStartRequest </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext);
		
		/// <summary>Member OnStopRequest </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aStatusCode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, System.Int32  aStatusCode);
		
		/// <summary>Member OnDataAvailable </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aInputStream'> </param>
		/// <param name='aOffset'> </param>
		/// <param name='aCount'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream  aInputStream, System.UInt32  aOffset, System.UInt32  aCount);
		
		/// <summary>Member GetBaseURIAttribute </summary>
		/// <returns>A nsIURI </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI  GetBaseURIAttribute();
		
		/// <summary>Member SetBaseURIAttribute </summary>
		/// <param name='aBaseURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI  aBaseURI);
		
		/// <summary>Member GetContentHandlerAttribute </summary>
		/// <returns>A nsISAXContentHandler </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXContentHandler  GetContentHandlerAttribute();
		
		/// <summary>Member SetContentHandlerAttribute </summary>
		/// <param name='aContentHandler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXContentHandler  aContentHandler);
		
		/// <summary>Member GetDtdHandlerAttribute </summary>
		/// <returns>A nsISAXDTDHandler </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXDTDHandler  GetDtdHandlerAttribute();
		
		/// <summary>Member SetDtdHandlerAttribute </summary>
		/// <param name='aDtdHandler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDtdHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXDTDHandler  aDtdHandler);
		
		/// <summary>Member GetErrorHandlerAttribute </summary>
		/// <returns>A nsISAXErrorHandler </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXErrorHandler  GetErrorHandlerAttribute();
		
		/// <summary>Member SetErrorHandlerAttribute </summary>
		/// <param name='aErrorHandler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetErrorHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXErrorHandler  aErrorHandler);
		
		/// <summary>Member GetLexicalHandlerAttribute </summary>
		/// <returns>A nsISAXLexicalHandler </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXLexicalHandler  GetLexicalHandlerAttribute();
		
		/// <summary>Member SetLexicalHandlerAttribute </summary>
		/// <param name='aLexicalHandler'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLexicalHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXLexicalHandler  aLexicalHandler);
		
		/// <summary>Member SetFeature </summary>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFeature([MarshalAs(UnmanagedType.LPStruct)] nsAString name, System.Boolean  value);
		
		/// <summary>Member GetFeature </summary>
		/// <param name='name'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFeature([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member SetProperty </summary>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.Interface)] nsISupports  value);
		
		/// <summary>Member GetProperty </summary>
		/// <param name='name'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member ParseFromString </summary>
		/// <param name='str'> </param>
		/// <param name='contentType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseFromString([MarshalAs(UnmanagedType.LPStruct)] nsAString str, [MarshalAs(UnmanagedType.LPStr)] System.String  contentType);
		
		/// <summary>Member ParseFromStream </summary>
		/// <param name='stream'> </param>
		/// <param name='charset'> </param>
		/// <param name='contentType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream  stream, [MarshalAs(UnmanagedType.LPStr)] System.String  charset, [MarshalAs(UnmanagedType.LPStr)] System.String  contentType);
		
		/// <summary>Member ParseAsync </summary>
		/// <param name='observer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver  observer);
	}
}