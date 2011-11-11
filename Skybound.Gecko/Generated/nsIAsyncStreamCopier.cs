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
// Generated by IDLImporter from file nsIAsyncStreamCopier.idl
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
	
	
	/// <summary>nsIAsyncStreamCopier </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5a19ca27-e041-4aca-8287-eb248d4c50c0")]
	public interface nsIAsyncStreamCopier : nsIRequest
	{
		
		/// <summary>
        /// The name of the request.  Often this is the URI of the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aName);
		
		/// <summary>
        /// Indicates whether the request is pending. nsIRequest::isPending is
        /// true when there is an outstanding asynchronous event that will make
        /// the request no longer be pending.  Requests do not necessarily start
        /// out pending; in some cases, requests have to be explicitly initiated
        /// (e.g. nsIChannel implementations are only pending once asyncOpen
        /// returns successfully).
        ///
        /// Requests can become pending multiple times during their lifetime.
        ///
        /// @return TRUE if the request has yet to reach completion.
        /// @return FALSE if the request has reached completion (e.g., after
        /// OnStopRequest has fired).
        /// @note Suspended requests are still considered pending.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsPending();
		
		/// <summary>
        /// The error status associated with the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetStatusAttribute();
		
		/// <summary>
        /// Cancels the current request.  This will close any open input or
        /// output streams and terminate any async requests.  Users should
        /// normally pass NS_BINDING_ABORTED, although other errors may also
        /// be passed.  The error passed in will become the value of the
        /// status attribute.
        ///
        /// Implementations must not send any notifications (e.g. via
        /// nsIRequestObserver) synchronously from this function. Similarly,
        /// removal from the load group (if any) must also happen asynchronously.
        ///
        /// Requests that use nsIStreamListener must not call onDataAvailable
        /// anymore after cancel has been called.
        ///
        /// @param aStatus the reason for canceling this request.
        ///
        /// NOTE: most nsIRequest implementations expect aStatus to be a
        /// failure code; however, some implementations may allow aStatus to
        /// be a success code such as NS_OK.  In general, aStatus should be
        /// a failure code.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Cancel(int aStatus);
		
		/// <summary>
        /// Suspends the current request.  This may have the effect of closing
        /// any underlying transport (in order to free up resources), although
        /// any open streams remain logically opened and will continue delivering
        /// data when the transport is resumed.
        ///
        /// Calling cancel() on a suspended request must not send any
        /// notifications (such as onstopRequest) until the request is resumed.
        ///
        /// NOTE: some implementations are unable to immediately suspend, and
        /// may continue to deliver events already posted to an event queue. In
        /// general, callers should be capable of handling events even after
        /// suspending a request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Suspend();
		
		/// <summary>
        /// Resumes the current request.  This may have the effect of re-opening
        /// any underlying transport and will resume the delivery of data to
        /// any open streams.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Resume();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsILoadGroup GetLoadGroupAttribute();
		
		/// <summary>
        /// The load group of this request.  While pending, the request is a
        /// member of the load group.  It is the responsibility of the request
        /// to implement this policy.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadGroupAttribute([MarshalAs(UnmanagedType.Interface)] nsILoadGroup aLoadGroup);
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetLoadFlagsAttribute();
		
		/// <summary>
        /// The load flags of this request.  Bits 0-15 are reserved.
        ///
        /// When added to a load group, this request's load flags are merged with
        /// the load flags of the load group.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLoadFlagsAttribute(uint aLoadFlags);
		
		/// <summary>
        /// Initialize the stream copier.
        ///
        /// @param aSource
        /// contains the data to be copied.
        /// @param aSink
        /// specifies the destination for the data.
        /// @param aTarget
        /// specifies the thread on which the copy will occur.  a null value
        /// is permitted and will cause the copy to occur on an unspecified
        /// background thread.
        /// @param aSourceBuffered
        /// true if aSource implements ReadSegments.
        /// @param aSinkBuffered
        /// true if aSink implements WriteSegments.
        /// @param aChunkSize
        /// specifies how many bytes to read/write at a time.  this controls
        /// the granularity of the copying.  it should match the segment size
        /// of the "buffered" streams involved.
        /// @param aCloseSource
        /// true if aSource should be closed after copying.
        /// @param aCloseSink
        /// true if aSink should be closed after copying.
        ///
        /// NOTE: at least one of the streams must be buffered.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIInputStream aSource, [MarshalAs(UnmanagedType.Interface)] nsIOutputStream aSink, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aTarget, [MarshalAs(UnmanagedType.Bool)] bool aSourceBuffered, [MarshalAs(UnmanagedType.Bool)] bool aSinkBuffered, uint aChunkSize, [MarshalAs(UnmanagedType.Bool)] bool aCloseSource, [MarshalAs(UnmanagedType.Bool)] bool aCloseSink);
		
		/// <summary>
        /// asyncCopy triggers the start of the copy.  The observer will be notified
        /// when the copy completes.
        ///
        /// @param aObserver
        /// receives notifications.
        /// @param aObserverContext
        /// passed to observer methods.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncCopy([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver aObserver, [MarshalAs(UnmanagedType.Interface)] nsISupports aObserverContext);
	}
}
