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
// Generated by IDLImporter from file nsIHapticFeedback.idl
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
	
	
	/// <summary>nsIHapticFeedback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("91917c98-a8f3-4c98-8f10-4afb872f54c7")]
	public interface nsIHapticFeedback
	{
		
		/// <summary>
        /// Perform haptic feedback
        ///
        /// @param isLongPress
        /// indicate whether feedback is for a long press (vs. short press)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PerformSimpleAction(int isLongPress);
	}
	
	/// <summary>nsIHapticFeedbackConsts </summary>
	public class nsIHapticFeedbackConsts
	{
		
		// 
		public const long ShortPress = 0;
		
		// 
		public const long LongPress = 1;
	}
}
