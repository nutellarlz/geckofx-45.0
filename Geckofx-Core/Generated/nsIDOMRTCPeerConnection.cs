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
// Generated by IDLImporter from file nsIDOMRTCPeerConnection.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("eb9c563c-3b09-4565-9317-eca96ae0c538")]
	public interface RTCPeerConnectionCallback
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
        /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnCallback(Gecko.JsVal value);
	}
	
	/// <summary>RTCPeerConnectionCallbackVoid </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("55546efd-287b-4460-8283-0592875b890f")]
	public interface RTCPeerConnectionCallbackVoid
	{
		
		/// <summary>Member OnCallback </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnCallback();
	}
	
	/// <summary>nsIDOMRTCSessionDescription </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("05d7375e-b024-4951-a570-c6642105ad35")]
	public interface nsIDOMRTCSessionDescription
	{
		
		/// <summary>Member GetSdpAttribute </summary>
		/// <param name='aSdp'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSdpAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSdp);
		
		/// <summary>Member SetSdpAttribute </summary>
		/// <param name='aSdp'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSdpAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSdp);
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>Member SetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
	}
	
	/// <summary>nsIDOMRTCIceCandidate </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("df176474-e20a-4f42-a85b-b0414d634cf0")]
	public interface nsIDOMRTCIceCandidate
	{
		
		/// <summary>Member GetCandidateAttribute </summary>
		/// <param name='aCandidate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCandidateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCandidate);
		
		/// <summary>Member SetCandidateAttribute </summary>
		/// <param name='aCandidate'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCandidateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCandidate);
		
		/// <summary>Member GetSdpMidAttribute </summary>
		/// <param name='aSdpMid'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSdpMidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSdpMid);
		
		/// <summary>Member SetSdpMidAttribute </summary>
		/// <param name='aSdpMid'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSdpMidAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSdpMid);
		
		/// <summary>Member GetSdpMLineIndexAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetSdpMLineIndexAttribute();
		
		/// <summary>Member SetSdpMLineIndexAttribute </summary>
		/// <param name='aSdpMLineIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSdpMLineIndexAttribute(ushort aSdpMLineIndex);
	}
	
	/// <summary>
    ///See http://dev.w3.org/2011/webrtc/editor/webrtc.html </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f888648c-5e6b-4af9-91ad-a911e53d7a39")]
	public interface nsIDOMRTCPeerConnection
	{
		
		/// <summary>
        ///See http://dev.w3.org/2011/webrtc/editor/webrtc.html </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateOffer(RTCPeerConnectionCallback successCallback, RTCPeerConnectionCallback failureCallback, Gecko.JsVal constraints);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateAnswer(RTCPeerConnectionCallback successCallback, RTCPeerConnectionCallback failureCallback, Gecko.JsVal constraints, [MarshalAs(UnmanagedType.U1)] bool createProvisionalAnswer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLocalDescription([MarshalAs(UnmanagedType.Interface)] nsIDOMRTCSessionDescription desc, RTCPeerConnectionCallback successCallback, RTCPeerConnectionCallback failureCallback);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRemoteDescription([MarshalAs(UnmanagedType.Interface)] nsIDOMRTCSessionDescription desc, RTCPeerConnectionCallback successCallback, RTCPeerConnectionCallback failureCallback);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateIce(Gecko.JsVal configuration, Gecko.JsVal constraints, [MarshalAs(UnmanagedType.U1)] bool restart);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddIceCandidate([MarshalAs(UnmanagedType.Interface)] nsIDOMRTCIceCandidate candidate, RTCPeerConnectionCallback successCallback, RTCPeerConnectionCallback failureCallback);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddStream([MarshalAs(UnmanagedType.Interface)] nsIDOMMediaStream stream, Gecko.JsVal constraints);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveStream([MarshalAs(UnmanagedType.Interface)] nsIDOMMediaStream stream);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        ///Readonly attributes </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIceStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIceState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIceGatheringStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIceGatheringState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReadyStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReadyState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetLocalDescriptionAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetRemoteDescriptionAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetLocalStreamsAttribute();
		
		/// <summary>
        /// MediaStream[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetRemoteStreamsAttribute();
		
		/// <summary>
        ///Event handlers. TODO: Use real EventTarget </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallback GetOnaddstreamAttribute();
		
		/// <summary>
        ///Event handlers. TODO: Use real EventTarget </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnaddstreamAttribute(RTCPeerConnectionCallback aOnaddstream);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallback GetOnopenAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnopenAttribute(RTCPeerConnectionCallback aOnopen);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallback GetOnremovestreamAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnremovestreamAttribute(RTCPeerConnectionCallback aOnremovestream);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallback GetOnicecandidateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnicecandidateAttribute(RTCPeerConnectionCallback aOnicecandidate);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallback GetOnstatechangeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnstatechangeAttribute(RTCPeerConnectionCallback aOnstatechange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallback GetOngatheringchangeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOngatheringchangeAttribute(RTCPeerConnectionCallback aOngatheringchange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallback GetOnicechangeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnicechangeAttribute(RTCPeerConnectionCallback aOnicechange);
		
		/// <summary>
        ///Data channels </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDataChannel CreateDataChannel([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase label, Gecko.JsVal options);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ConnectDataConnection(ushort localport, ushort remoteport, ushort numstreams);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallback GetOndatachannelAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndatachannelAttribute(RTCPeerConnectionCallback aOndatachannel);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallbackVoid GetOnconnectionAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnconnectionAttribute(RTCPeerConnectionCallbackVoid aOnconnection);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		RTCPeerConnectionCallbackVoid GetOnclosedconnectionAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnclosedconnectionAttribute(RTCPeerConnectionCallbackVoid aOnclosedconnection);
	}
}
