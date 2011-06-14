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
// Generated by IDLImporter from file nsISeekableStream.idl
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
    /// nsISeekableStream
    ///
    /// Note that a stream might not implement all methods (e.g., a readonly stream
    /// won't implement setEOF)
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8429d350-1040-4661-8b71-f2a6ba455980")]
	public interface nsISeekableStream
	{
		
		/// <summary>
        /// seek
        ///
        /// This method moves the stream offset of the steam implementing this
        /// interface.
        ///
        /// @param whence specifies how to interpret the 'offset' parameter in
        /// setting the stream offset associated with the implementing
        /// stream.
        ///
        /// @param offset specifies a value, in bytes, that is used in conjunction
        /// with the 'whence' parameter to set the stream offset of the
        /// implementing stream.  A negative value causes seeking in
        /// the reverse direction.
        ///
        /// @throws NS_BASE_STREAM_CLOSED if called on a closed stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Seek(int whence, int offset);
		
		/// <summary>
        /// tell
        ///
        /// This method reports the current offset, in bytes, from the start of the
        /// stream.
        ///
        /// @throws NS_BASE_STREAM_CLOSED if called on a closed stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Tell();
		
		/// <summary>
        /// setEOF
        ///
        /// This method truncates the stream at the current offset.
        ///
        /// @throws NS_BASE_STREAM_CLOSED if called on a closed stream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEOF();
	}
}
