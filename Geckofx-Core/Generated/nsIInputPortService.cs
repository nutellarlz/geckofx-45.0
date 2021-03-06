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
// Generated by IDLImporter from file nsIInputPortService.idl
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
    /// XPCOM component which acts as the container for input port data.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("244a2b1d-aa1f-4188-a639-ddb56c554b6d")]
	public interface nsIInputPortData
	{
		
		/// <summary>
        /// XPCOM component which acts as the container for input port data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
		
		/// <summary>
        /// XPCOM component which acts as the container for input port data.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetConnectedAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetConnectedAttribute([MarshalAs(UnmanagedType.U1)] bool aConnected);
	}
	
	/// <summary>nsIInputPortListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("32a62e7c-f698-4846-81f7-617c87854d32")]
	public interface nsIInputPortListener
	{
		
		/// <summary>Member NotifyConnectionChanged </summary>
		/// <param name='portId'> </param>
		/// <param name='isConnected'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyConnectionChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase portId, [MarshalAs(UnmanagedType.U1)] bool isConnected);
	}
	
	/// <summary>nsIInputPortServiceCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c2a47757-25f6-4bc8-bd27-c23af2d87381")]
	public interface nsIInputPortServiceCallback
	{
		
		/// <summary>
        /// Called when something wrong happens.
        ///
        /// @param errorCode Error code listed above from the underlying layer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyError(ushort errorCode);
		
		/// <summary>
        /// Called when the operation succeeds.
        ///
        /// @param dataList A list of data.
        /// An array of |nsIInputPortData| when used for |getInputPorts()|.
        ///
        /// NOTE: |nsIArray| is adopted to prevent this interface from being split into
        /// multiple interfaces with different |notifySuccess|. Though the
        /// implementation of TV service may need |nsIMutableArray| to fill in the
        /// array, it doesn't seem necessary for other places to use the mutable one.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifySuccess([MarshalAs(UnmanagedType.Interface)] nsIArray dataList);
	}
	
	/// <summary>nsIInputPortServiceCallbackConsts </summary>
	public class nsIInputPortServiceCallbackConsts
	{
		
		// 
		public const ushort INPUTPORT_ERROR_OK = 0;
		
		// 
		public const ushort INPUTPORT_ERROR_FAILURE = 1;
		
		// 
		public const ushort INPUTPORT_ERROR_INVALID_ARG = 2;
		
		// 
		public const ushort INPUTPORT_ERROR_NOT_SUPPORTED = 3;
	}
	
	/// <summary>nsIInputPortService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6214dae0-840e-11e4-b4a9-0800200c9a66")]
	public interface nsIInputPortService
	{
		
		/// <summary>Member GetInputPortListenerAttribute </summary>
		/// <returns>A nsIInputPortListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputPortListener GetInputPortListenerAttribute();
		
		/// <summary>Member SetInputPortListenerAttribute </summary>
		/// <param name='aInputPortListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInputPortListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputPortListener aInputPortListener);
		
		/// <summary>Member GetInputPorts </summary>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInputPorts([MarshalAs(UnmanagedType.Interface)] nsIInputPortServiceCallback callback);
	}
}
