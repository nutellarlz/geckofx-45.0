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
// Generated by IDLImporter from file nsITaskbarPreviewController.idl
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
	
	
	/// <summary>
    /// nsITaskbarPreviewController
    ///
    /// nsITaskbarPreviewController provides the behavior for the taskbar previews.
    /// Its methods and properties are used by nsITaskbarPreview. Clients are
    /// intended to provide their own implementation of this interface. Depending on
    /// the interface the controller is attached to, only certain methods/attributes
    /// are required to be implemented.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4FC0AFBB-3E22-4FBA-AC21-953350AF0411")]
	public interface nsITaskbarPreviewController
	{
		
		/// <summary>
        /// The width of the preview image. This value is allowed to change at any
        /// time. See drawPreview for more information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetWidthAttribute();
		
		/// <summary>
        /// The height of the preview image. This value is allowed to change at any
        /// time.  See drawPreview for more information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetHeightAttribute();
		
		/// <summary>
        /// The aspect ratio of the thumbnail - this does not need to match the ratio
        /// of the preview. This value is allowed to change at any time. See
        /// drawThumbnail for more information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetThumbnailAspectRatioAttribute();
		
		/// <summary>
        /// Invoked by nsITaskbarPreview when it needs to render the preview. The
        /// context is attached to a surface with the controller's width and height
        /// which are obtained immediately before the call.
        ///
        /// Note that the context is not attached to a canvas element.
        ///
        /// @param ctx Canvas drawing context
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DrawPreview([MarshalAs(UnmanagedType.Interface)] nsIDOMCanvasRenderingContext2D ctx);
		
		/// <summary>
        /// Invoked by the taskbar preview when it needs to draw the thumbnail in the
        /// taskbar's application preview window.
        ///
        /// Note: it is guaranteed that width/height == thumbnailAspectRatio
        /// (modulo rounding errors)
        ///
        /// Also note that the context is not attached to a canvas element.
        ///
        /// @param ctx Canvas drawing context
        /// @param width The width of the surface backing the drawing context
        /// @param height The height of the surface backing the drawing context
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DrawThumbnail([MarshalAs(UnmanagedType.Interface)] nsIDOMCanvasRenderingContext2D ctx, uint width, uint height);
		
		/// <summary>
        /// Invoked when the user presses the close button on the tab preview.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnClose();
		
		/// <summary>
        /// Invoked when the user clicks on the tab preview.
        ///
        /// @return true if the top level window corresponding to the preview should
        /// be activated, false if activation is not accepted.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnActivate();
		
		/// <summary>
        /// Invoked when one of the buttons on the window preview's toolbar is pressed.
        ///
        /// @param button The button that was pressed. This can be compared with the
        /// buttons returned by nsITaskbarWindowPreview.getButton.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnClick([MarshalAs(UnmanagedType.Interface)] nsITaskbarPreviewButton button);
	}
}
