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
// Generated by IDLImporter from file nsITXTToHTMLConv.idl
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
	
	
	/// <summary>nsITXTToHTMLConv </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("933355f6-1dd2-11b2-a9b0-d335b9e35983")]
	public interface nsITXTToHTMLConv : nsIStreamConverter
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, System.Int32  aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// If that number is greater than or equal to 2^32, this parameter
        /// will be PR_UINT32_MAX (2^32 - 1).
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream  aInputStream, System.UInt32  aOffset, System.UInt32  aCount);
		
		/// <summary>
        /// <b>SYNCRONOUS VERSION</b>
        /// Converts a stream of one type, to a stream of another type.
        ///
        /// Use this method when you have a stream you want to convert.
        ///
        /// @param aFromStream   The stream representing the original/raw data.
        /// @param aFromType     The MIME type of aFromStream.
        /// @param aToType       The MIME type of the returned stream.
        /// @param aCtxt         Either an opaque context, or a converter specific context
        /// (implementation specific).
        /// @return              The converted stream. NOTE: The returned stream may not
        /// already be converted. An efficient stream converter
        /// implementation will converter data on demand rather than
        /// buffering the converted data until it is used.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream Convert([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aFromStream, [MarshalAs(UnmanagedType.LPStr)] System.String  aFromType, [MarshalAs(UnmanagedType.LPStr)] System.String  aToType, [MarshalAs(UnmanagedType.Interface)] nsISupports  aCtxt);
		
		/// <summary>
        /// <b>ASYNCRONOUS VERSION</b>
        /// Converts data arriving via the converter's nsIStreamListener::OnDataAvailable()
        /// method from one type to another, pushing the converted data out to the caller
        /// via aListener::OnDataAvailable().
        ///
        /// Use this method when you want to proxy (and convert) nsIStreamListener callbacks
        /// asynchronously.
        ///
        /// @param aFromType     The MIME type of the original/raw data.
        /// @param aToType       The MIME type of the converted data.
        /// @param aListener     The listener who receives the converted data.
        /// @param aCtxt         Either an opaque context, or a converter specific context
        /// (implementation specific).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AsyncConvertData([MarshalAs(UnmanagedType.LPStr)] System.String  aFromType, [MarshalAs(UnmanagedType.LPStr)] System.String  aToType, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener  aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports  aCtxt);
		
		/// <summary>
        /// @param text: Title to set for the HTML document.  Only applicable if
        /// preFormatHTML(true) is called.
        /// @result      The given title will be used to form an HTML document
        /// from the plain text document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string text);
		
		/// <summary>
        /// @param value: true to use an HTML header and footer on the document,
        /// false to omit it.
        /// @result       The document will use a header and footer if value is
        /// true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreFormatHTML(System.Boolean  value);
	}
}
