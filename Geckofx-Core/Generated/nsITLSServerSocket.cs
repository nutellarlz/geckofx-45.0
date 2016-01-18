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
// Generated by IDLImporter from file nsITLSServerSocket.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cc2c30f9-cfaa-4b8a-bd44-c24881981b74")]
	public interface nsITLSServerSocket : nsIServerSocket
	{
		
		/// <summary>
        /// init
        ///
        /// This method initializes a server socket.
        ///
        /// @param aPort
        /// The port of the server socket.  Pass -1 to indicate no preference,
        /// and a port will be selected automatically.
        /// @param aLoopbackOnly
        /// If true, the server socket will only respond to connections on the
        /// local loopback interface.  Otherwise, it will accept connections
        /// from any interface.  To specify a particular network interface,
        /// use initWithAddress.
        /// @param aBackLog
        /// The maximum length the queue of pending connections may grow to.
        /// This parameter may be silently limited by the operating system.
        /// Pass -1 to use the default value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Init(int aPort, [MarshalAs(UnmanagedType.U1)] bool aLoopbackOnly, int aBackLog);
		
		/// <summary>
        /// initSpecialConnection
        ///
        /// This method initializes a server socket and offers the ability to have
        /// that socket not get terminated if Gecko is set offline.
        ///
        /// @param aPort
        /// The port of the server socket.  Pass -1 to indicate no preference,
        /// and a port will be selected automatically.
        /// @param aFlags
        /// Flags for the socket.
        /// @param aBackLog
        /// The maximum length the queue of pending connections may grow to.
        /// This parameter may be silently limited by the operating system.
        /// Pass -1 to use the default value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitSpecialConnection(int aPort, ulong aFlags, int aBackLog);
		
		/// <summary>
        /// initWithAddress
        ///
        /// This method initializes a server socket, and binds it to a particular
        /// local address (and hence a particular local network interface).
        ///
        /// @param aAddr
        /// The address to which this server socket should be bound.
        /// @param aBackLog
        /// The maximum length the queue of pending connections may grow to.
        /// This parameter may be silently limited by the operating system.
        /// Pass -1 to use the default value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitWithAddress(System.IntPtr aAddr, int aBackLog);
		
		/// <summary>
        /// initWithFilename
        ///
        /// This method initializes a Unix domain or "local" server socket. Such
        /// a socket has a name in the filesystem, like an ordinary file. To
        /// connect, a client supplies the socket's filename, and the usual
        /// permission checks on socket apply.
        ///
        /// This makes Unix domain sockets useful for communication between the
        /// programs being run by a specific user on a single machine: the
        /// operating system takes care of authentication, and the user's home
        /// directory or profile directory provide natural per-user rendezvous
        /// points.
        ///
        /// Since Unix domain sockets are always local to the machine, they are
        /// not affected by the nsIIOService's 'offline' flag.
        ///
        /// The system-level socket API may impose restrictions on the length of
        /// the filename that are stricter than those of the underlying
        /// filesystem. If the file name is too long, this returns
        /// NS_ERROR_FILE_NAME_TOO_LONG.
        ///
        /// All components of the path prefix of |aPath| must name directories;
        /// otherwise, this returns NS_ERROR_FILE_NOT_DIRECTORY.
        ///
        /// This call requires execute permission on all directories containing
        /// the one in which the socket is to be created, and write and execute
        /// permission on the directory itself. Otherwise, this returns
        /// NS_ERROR_CONNECTION_REFUSED.
        ///
        /// This call creates the socket's directory entry. There must not be
        /// any existing entry with the given name. If there is, this returns
        /// NS_ERROR_SOCKET_ADDRESS_IN_USE.
        ///
        /// On systems that don't support Unix domain sockets at all, this
        /// returns NS_ERROR_SOCKET_ADDRESS_NOT_SUPPORTED.
        ///
        /// @param aPath nsIFile
        /// The file name at which the socket should be created.
        ///
        /// @param aPermissions unsigned long
        /// Unix-style permission bits to be applied to the new socket.
        ///
        /// Note about permissions: Linux's unix(7) man page claims that some
        /// BSD-derived systems ignore permissions on UNIX-domain sockets;
        /// NetBSD's bind(2) man page agrees, but says it does check now (dated
        /// 2005). POSIX has required 'connect' to fail if write permission on
        /// the socket itself is not granted since 2003 (Issue 6). NetBSD says
        /// that the permissions on the containing directory (execute) have
        /// always applied, so creating sockets in appropriately protected
        /// directories should be secure on both old and new systems.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitWithFilename([MarshalAs(UnmanagedType.Interface)] nsIFile aPath, uint aPermissions, int aBacklog);
		
		/// <summary>
        /// close
        ///
        /// This method closes a server socket.  This does not affect already
        /// connected client sockets (i.e., the nsISocketTransport instances
        /// created from this server socket).  This will cause the onStopListening
        /// event to asynchronously fire with a status of NS_BINDING_ABORTED.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Close();
		
		/// <summary>
        /// asyncListen
        ///
        /// This method puts the server socket in the listening state.  It will
        /// asynchronously listen for and accept client connections.  The listener
        /// will be notified once for each client connection that is accepted.  The
        /// listener's onSocketAccepted method will be called on the same thread
        /// that called asyncListen (the calling thread must have a nsIEventTarget).
        ///
        /// The listener will be passed a reference to an already connected socket
        /// transport (nsISocketTransport).  See below for more details.
        ///
        /// @param aListener
        /// The listener to be notified when client connections are accepted.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AsyncListen([MarshalAs(UnmanagedType.Interface)] nsIServerSocketListener aListener);
		
		/// <summary>
        /// Returns the port of this server socket.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetPortAttribute();
		
		/// <summary>
        /// Returns the address to which this server socket is bound.  Since a
        /// server socket may be bound to multiple network devices, this address
        /// may not necessarily be specific to a single network device.  In the
        /// case of an IP socket, the IP address field would be zerod out to
        /// indicate a server socket bound to all network devices.  Therefore,
        /// this method cannot be used to determine the IP address of the local
        /// system.  See nsIDNSService::myHostName if this is what you need.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetAddress();
		
		/// <summary>
        /// serverCert
        ///
        /// The server's certificate that is presented to the client during the TLS
        /// handshake.  This is required to be set before calling |asyncListen|.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509Cert GetServerCertAttribute();
		
		/// <summary>
        /// serverCert
        ///
        /// The server's certificate that is presented to the client during the TLS
        /// handshake.  This is required to be set before calling |asyncListen|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetServerCertAttribute([MarshalAs(UnmanagedType.Interface)] nsIX509Cert aServerCert);
		
		/// <summary>
        /// setSessionCache
        ///
        /// Whether the server should use a session cache.  Defaults to true.  This
        /// should be set before calling |asyncListen| if you wish to change the
        /// default.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSessionCache([MarshalAs(UnmanagedType.U1)] bool aSessionCache);
		
		/// <summary>
        /// setSessionTickets
        ///
        /// Whether the server should support session tickets.  Defaults to true.  This
        /// should be set before calling |asyncListen| if you wish to change the
        /// default.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSessionTickets([MarshalAs(UnmanagedType.U1)] bool aSessionTickets);
		
		/// <summary>
        /// setRequestClientCertificate
        ///
        /// Whether the server should request and/or require a client auth certificate
        /// from the client.  Defaults to REQUEST_NEVER.  See the possible options
        /// above.  This should be set before calling |asyncListen| if you wish to
        /// change the default.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestClientCertificate(uint aRequestClientCert);
		
		/// <summary>
        /// setCipherSuites
        ///
        /// The server's cipher suites that is used by the TLS handshake.
        /// This is required to be set before calling |asyncListen|.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCipherSuites(unsigned short aCipherSuites, uint aLength);
	}
	
	/// <summary>nsITLSServerSocketConsts </summary>
	public class nsITLSServerSocketConsts
	{
		
		// <summary>
        // Never request
        // </summary>
		public const ulong REQUEST_NEVER = 0;
		
		// <summary>
        // Request (but do not require) during the first handshake only
        // </summary>
		public const ulong REQUEST_FIRST_HANDSHAKE = 1;
		
		// <summary>
        // Request (but do not require) during each handshake
        // </summary>
		public const ulong REQUEST_ALWAYS = 2;
		
		// <summary>
        // Require during the first handshake only
        // </summary>
		public const ulong REQUIRE_FIRST_HANDSHAKE = 3;
		
		// <summary>
        // Require during each handshake
        // </summary>
		public const ulong REQUIRE_ALWAYS = 4;
	}
	
	/// <summary>
    /// Security summary for a given TLS client connection being handled by a
    /// |nsITLSServerSocket| server.
    ///
    /// This is accessible through the security info object on the transport, which
    /// will be an instance of |nsITLSServerConnectionInfo| (see below).
    ///
    /// The values of these attributes are available once the |onHandshakeDone|
    /// method of the security observer has been called (see
    /// |nsITLSServerSecurityObserver| below).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("19668ea4-e5ad-4182-9698-7e890d48f327")]
	public interface nsITLSClientStatus
	{
		
		/// <summary>
        /// peerCert
        ///
        /// The client's certificate, if one was requested via |requestCertificate|
        /// above and supplied by the client.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIX509Cert GetPeerCertAttribute();
		
		/// <summary>
        /// tlsVersionUsed
        ///
        /// The version of TLS used by the connection.  See values above.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetTlsVersionUsedAttribute();
		
		/// <summary>
        /// cipherName
        ///
        /// Name of the cipher suite used, such as
        /// "TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256".
        /// See security/nss/lib/ssl/sslinfo.c for the possible values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCipherNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCipherName);
		
		/// <summary>
        /// keyLength
        ///
        /// The "effective" key size of the symmetric key in bits.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetKeyLengthAttribute();
		
		/// <summary>
        /// macLength
        ///
        /// The size of the MAC in bits.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetMacLengthAttribute();
	}
	
	/// <summary>nsITLSClientStatusConsts </summary>
	public class nsITLSClientStatusConsts
	{
		
		// <summary>
        // Values for tlsVersionUsed, as defined by TLS
        // </summary>
		public const short SSL_VERSION_3 = 0x0300;
		
		// 
		public const short TLS_VERSION_1 = 0x0301;
		
		// 
		public const short TLS_VERSION_1_1 = 0x0302;
		
		// 
		public const short TLS_VERSION_1_2 = 0x0303;
		
		// 
		public const short TLS_VERSION_UNKNOWN = -1;
	}
	
	/// <summary>
    /// Connection info for a given TLS client connection being handled by a
    /// |nsITLSServerSocket| server.  This object is thread-safe.
    ///
    /// This is exposed as the security info object on the transport, so it can be
    /// accessed via |transport.securityInfo|.
    ///
    /// This interface is available by the time the |onSocketAttached| is called,
    /// which is the first time the TLS server consumer is notified of a new client.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8a93f5d5-eddd-4c62-a4bd-bfd297653184")]
	public interface nsITLSServerConnectionInfo
	{
		
		/// <summary>
        /// setSecurityObserver
        ///
        /// Set the security observer to be notified when the TLS handshake has
        /// completed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecurityObserver([MarshalAs(UnmanagedType.Interface)] nsITLSServerSecurityObserver observer);
		
		/// <summary>
        /// serverSocket
        ///
        /// The nsITLSServerSocket instance that accepted this client connection.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITLSServerSocket GetServerSocketAttribute();
		
		/// <summary>
        /// status
        ///
        /// Security summary for this TLS client connection.  Note that the values of
        /// this interface are not available until the TLS handshake has completed.
        /// See |nsITLSClientStatus| above for more details.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITLSClientStatus GetStatusAttribute();
	}
	
	/// <summary>nsITLSServerSecurityObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1f62e1ae-e546-4a38-8917-d428472ed736")]
	public interface nsITLSServerSecurityObserver
	{
		
		/// <summary>
        /// onHandsakeDone
        ///
        /// This method is called once the TLS handshake is completed.  This takes
        /// place after |onSocketAccepted| has been called, which typically opens the
        /// streams to keep things moving along. It's important to be aware that the
        /// handshake has not completed at the point that |onSocketAccepted| is called,
        /// so no security verification can be done until this method is called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnHandshakeDone([MarshalAs(UnmanagedType.Interface)] nsITLSServerSocket aServer, [MarshalAs(UnmanagedType.Interface)] nsITLSClientStatus aStatus);
	}
}