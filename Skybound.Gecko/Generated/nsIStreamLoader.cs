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
// Generated by IDLImporter from file nsIStreamLoader.idl
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
	
	
	/// <summary>nsIStreamLoaderObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("359F7990-D4E9-11d3-A1A5-0050041CAF44")]
	public interface nsIStreamLoaderObserver
	{
		
		/// <summary>
        /// Called when the entire stream has been loaded.
        ///
        /// @param loader the stream loader that loaded the stream.
        /// @param ctxt the context parameter of the underlying channel
        /// @param status the status of the underlying channel
        /// @param resultLength the length of the data loaded
        /// @param result the data
        ///
        /// This method will always be called asynchronously by the
        /// nsIStreamLoader involved, on the thread that called the
        /// loader's init() method.
        ///
        /// If the observer wants to take over responsibility for the
        /// data buffer (result), it returns NS_SUCCESS_ADOPTED_DATA
        /// in place of NS_OK as its success code. The loader will then
        /// "forget" about the data, and not NS_Free() it in its own
        /// destructor; observer must call NS_Free() when the data is
        /// no longer required.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStreamComplete([MarshalAs(UnmanagedType.Interface)] nsIStreamLoader  loader, [MarshalAs(UnmanagedType.Interface)] nsISupports  ctxt, System.Int32  status, System.UInt32  resultLength, System.IntPtr  result);
	}
	
	/// <summary>
    /// Asynchronously loads a channel into a memory buffer.
    ///
    /// To use this interface, first call init() with a nsIStreamLoaderObserver
    /// that will be notified when the data has been loaded. Then call asyncOpen()
    /// on the channel with the nsIStreamLoader as the listener. The context
    /// argument in the asyncOpen() call will be passed to the onStreamComplete()
    /// callback.
    ///
    /// XXX define behaviour for sizes >4 GB
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8ea7e890-8211-11d9-8bde-f66bad1e3f3a")]
	public interface nsIStreamLoader : nsIStreamListener
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
        /// Initialize this stream loader, and start loading the data.
        ///
        /// @param aObserver
        /// An observer that will be notified when the data is complete.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIStreamLoaderObserver  aObserver);
		
		/// <summary>
        /// Gets the number of bytes read so far.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetNumBytesReadAttribute();
		
		/// <summary>
        /// Gets the request that loaded this file.
        /// null after the request has finished loading.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRequest  GetRequestAttribute();
	}
}
