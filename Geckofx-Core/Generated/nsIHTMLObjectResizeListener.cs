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
// Generated by IDLImporter from file nsIHTMLObjectResizeListener.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;

	
	
	/// <summary>nsIHTMLObjectResizeListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("27b00295-349c-429f-ad0c-87b859e77130")]
	public interface nsIHTMLObjectResizeListener
	{
		
		/// <summary>
        /// Listener's callback called by the editor when the user
        /// starts resizing an element
        /// @param aElement [IN] the element
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStartResizing([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement);
		
		/// <summary>
        /// Listener's callback called by the editor when the user
        /// has finalized the resizing of an element
        /// @param aElement [IN] the element that was resized
        /// @param aOldWidth  [IN] the width of the element before resizing
        /// @param aOldHeight [IN] the height of the element before resizing
        /// @param aNewWidth  [IN] the width of the element after resizing
        /// @param aNewHeight [IN] the height of the element after resizing
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnEndResizing([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, int aOldWidth, int aOldHeight, int aNewWidth, int aNewHeight);
	}
}