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
// Generated by IDLImporter from file nsIXULBuilderListener.idl
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
    /// when a template builder rebuilds its content.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ac46be8f-c863-4c23-84a2-d0fcc8dfa9f4")]
	public interface nsIXULBuilderListener
	{
		
		/// <summary>
        /// Called before a template builder rebuilds its content.
        /// @param aBuilder the template builder that rebuilds the content.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WillRebuild([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateBuilder  aBuilder);
		
		/// <summary>
        /// Called after a template builder has rebuilt its content.
        /// @param aBuilder the template builder that has rebuilt the content.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DidRebuild([MarshalAs(UnmanagedType.Interface)] nsIXULTemplateBuilder  aBuilder);
	}
}
