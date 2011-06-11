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
// Generated by IDLImporter from file nsIPipe.idl
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
	
	
	/// <summary>
    /// nsIPipe represents an in-process buffer that can be read using nsIInputStream
    /// and written using nsIOutputStream.  The reader and writer of a pipe do not
    /// have to be on the same thread.  As a result, the pipe is an ideal mechanism
    /// to bridge data exchange between two threads.  For example, a worker thread
    /// might write data to a pipe from which the main thread will read.
    ///
    /// Each end of the pipe can be either blocking or non-blocking.  Recall that a
    /// non-blocking stream will return NS_BASE_STREAM_WOULD_BLOCK if it cannot be
    /// read or written to without blocking the calling thread.  For example, if you
    /// try to read from an empty pipe that has not yet been closed, then if that
    /// pipe's input end is non-blocking, then the read call will fail immediately
    /// with NS_BASE_STREAM_WOULD_BLOCK as the error condition.  However, if that
    /// pipe's input end is blocking, then the read call will not return until the
    /// pipe has data or until the pipe is closed.  This example presumes that the
    /// pipe is being filled asynchronously on some background thread.
    ///
    /// The pipe supports nsIAsyncInputStream and nsIAsyncOutputStream, which give
    /// the user of a non-blocking pipe the ability to wait for the pipe to become
    /// ready again.  For example, in the case of an empty non-blocking pipe, the
    /// user can call AsyncWait on the input end of the pipe to be notified when
    /// the pipe has data to read (or when the pipe becomes closed).
    ///
    /// NS_NewPipe2 and NS_NewPipe provide convenient pipe constructors.  In most
    /// cases nsIPipe is not actually used.  It is usually enough to just get
    /// references to the pipe's input and output end.  In which case, the pipe is
    /// automatically closed when the respective pipe ends are released.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f4211abc-61b3-11d4-9877-00c04fa0cf4a")]
	public interface nsIPipe
	{
		
		/// <summary>
        /// initialize this pipe
        ///
        /// @param nonBlockingInput
        /// true specifies non-blocking input stream behavior
        /// @param nonBlockingOutput
        /// true specifies non-blocking output stream behavior
        /// @param segmentSize
        /// specifies the segment size in bytes (pass 0 to use default value)
        /// @param segmentCount
        /// specifies the max number of segments (pass 0 to use default
        /// value).   Passing PR_UINT32_MAX here causes the pipe to have
        /// "infinite" space.  This mode can be useful in some cases, but
        /// should always be used with caution.  The default value for this
        /// parameter is a finite value.
        /// @param segmentAllocator
        /// pass reference to nsIMemory to have all pipe allocations use this
        /// allocator (pass null to use the default allocator)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init(System.Boolean  nonBlockingInput, System.Boolean  nonBlockingOutput, System.UInt32  segmentSize, System.UInt32  segmentCount, [MarshalAs(UnmanagedType.Interface)] nsIMemory  segmentAllocator);
		
		/// <summary>
        /// The pipe's input end, which also implements nsISearchableInputStream.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAsyncInputStream  GetInputStreamAttribute();
		
		/// <summary>
        /// The pipe's output end.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAsyncOutputStream  GetOutputStreamAttribute();
	}
	
	/// <summary>
    /// XXX this interface doesn't really belong in here.  It is here because
    /// currently nsPipeInputStream is the only implementation of this interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8C39EF62-F7C9-11d4-98F5-001083010E9B")]
	public interface nsISearchableInputStream
	{
		
		/// <summary>
        /// Searches for a string in the input stream. Since the stream has a notion
        /// of EOF, it is possible that the string may at some time be in the
        /// buffer, but is is not currently found up to some offset. Consequently,
        /// both the found and not found cases return an offset:
        /// if found, return offset where it was found
        /// if not found, return offset of the first byte not searched
        /// In the case the stream is at EOF and the string is not found, the first
        /// byte not searched will correspond to the length of the buffer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Search([MarshalAs(UnmanagedType.LPStr)] System.String  forString, System.Boolean  ignoreCase, out System.Boolean  found, out System.UInt32  offsetSearchedTo);
	}
}
