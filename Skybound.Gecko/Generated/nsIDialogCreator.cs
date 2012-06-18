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
// Generated by IDLImporter from file nsIDialogCreator.idl
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
	
	
	/// <summary>nsIDialogCreator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("17c9e659-2a9a-4a58-8a1c-d76bb58339c0")]
	public interface nsIDialogCreator
	{
		
		/// <summary>Member OpenDialog </summary>
		/// <param name='aType'> </param>
		/// <param name='aName'> </param>
		/// <param name='aFeatures'> </param>
		/// <param name='aArguments'> </param>
		/// <param name='aFrameElement'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenDialog(uint aType, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFeatures, [MarshalAs(UnmanagedType.Interface)] nsIDialogParamBlock aArguments, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aFrameElement);
	}
	
	/// <summary>nsIDialogCreatorConsts </summary>
	public class nsIDialogCreatorConsts
	{
		
		// 
		public const ulong UNKNOWN_DIALOG = 0;
		
		// 
		public const ulong GENERIC_DIALOG = 1;
		
		// 
		public const ulong SELECT_DIALOG = 2;
	}
}
