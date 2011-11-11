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
// Generated by IDLImporter from file mozIStorageFunction.idl
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
    /// mozIStorageFunction is to be implemented by storage consumers that
    /// wish to receive callbacks during the request execution.
    ///
    /// SQL can apply functions to values from tables. Examples of
    /// such functions are MIN(a1,a2) or SQRT(num). Many functions are
    /// implemented in SQL engine.
    ///
    /// This interface allows consumers to implement their own,
    /// problem-specific functions.
    /// These functions can be called from triggers, too.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9ff02465-21cb-49f3-b975-7d5b38ceec73")]
	public interface mozIStorageFunction
	{
		
		/// <summary>
        /// onFunctionCall is called when execution of a custom
        /// function should occur.
        ///
        /// @param aNumArguments         The number of arguments
        /// @param aFunctionArguments    The arguments passed in to the function
        ///
        /// @returns any value as Variant type.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant OnFunctionCall(mozIStorageValueArray aFunctionArguments);
	}
}
