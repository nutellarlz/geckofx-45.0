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
// Generated by IDLImporter from file inISearchObserver.idl
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
	
	
	/// <summary>inISearchObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("46226D9B-E398-4106-8D9B-225D4D0589F5")]
	public interface inISearchObserver
	{
		
		/// <summary>
        /// search stopped due to an error
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSearchStart(inISearchProcess aModule);
		
		/// <summary>Member OnSearchResult </summary>
		/// <param name='aModule'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSearchResult(inISearchProcess aModule);
		
		/// <summary>Member OnSearchEnd </summary>
		/// <param name='aModule'> </param>
		/// <param name='aResult'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSearchEnd(inISearchProcess aModule, short aResult);
		
		/// <summary>Member OnSearchError </summary>
		/// <param name='aModule'> </param>
		/// <param name='aMessage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSearchError(inISearchProcess aModule, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMessage);
	}
	
	/// <summary>inISearchObserverConsts </summary>
	public class inISearchObserverConsts
	{
		
		// <summary>
        // result codes which are sent to onSearchEnd
        // </summary>
		public const int IN_SUCCESS = 1;
		
		// <summary>
        // search completed successfully
        // </summary>
		public const int IN_INTERRUPTED = 2;
		
		// <summary>
        // search stopped due to user interruption
        // </summary>
		public const int IN_ERROR = 3;
	}
}
