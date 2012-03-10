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
// Generated by IDLImporter from file nsIPlaintextEditor.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>nsIPlaintextEditor </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("05d312ef-8914-494e-91c9-2be8ed7f8e29")]
	public interface nsIPlaintextEditor
	{
		
		/// <summary>
        /// The length of the contents in characters.
        /// XXX change this type to 'unsigned long'
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTextLengthAttribute();
		
		/// <summary>
        /// The maximum number of characters allowed.
        /// default: -1 (unlimited).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMaxTextLengthAttribute();
		
		/// <summary>
        /// The maximum number of characters allowed.
        /// default: -1 (unlimited).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMaxTextLengthAttribute(int aMaxTextLength);
		
		/// <summary>
        ///Get and set the body wrap width.
        ///
        /// Special values:
        /// 0 = wrap to window width
        /// -1 = no wrap at all
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetWrapWidthAttribute();
		
		/// <summary>
        ///Get and set the body wrap width.
        ///
        /// Special values:
        /// 0 = wrap to window width
        /// -1 = no wrap at all
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWrapWidthAttribute(int aWrapWidth);
		
		/// <summary>
        /// Similar to the setter for wrapWidth, but just sets the editor
        /// internal state without actually changing the content being edited
        /// to wrap at that column.  This should only be used by callers who
        /// are sure that their content is already set up correctly.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWrapColumn(int aWrapColumn);
		
		/// <summary>
        ///Get and set newline handling.
        ///
        /// Values are the constants defined above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNewlineHandlingAttribute();
		
		/// <summary>
        ///Get and set newline handling.
        ///
        /// Values are the constants defined above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNewlineHandlingAttribute(int aNewlineHandling);
		
		/// <summary>
        /// Inserts a string at the current location,
        /// given by the selection.
        /// If the selection is not collapsed, the selection is deleted
        /// and the insertion takes place at the resulting collapsed selection.
        ///
        /// @param aString   the string to be inserted
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertText([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aStringToInsert);
		
		/// <summary>
        /// Insert a line break into the content model.
        /// The interpretation of a break is up to the implementation:
        /// it may enter a character, split a node in the tree, etc.
        /// This may be more efficient than calling InsertText with a newline.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertLineBreak();
	}
}
