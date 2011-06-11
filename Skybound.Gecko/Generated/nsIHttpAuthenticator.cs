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
// Generated by IDLImporter from file nsIHttpAuthenticator.idl
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
    /// nsIHttpAuthenticator
    ///
    /// Interface designed to allow for pluggable HTTP authentication modules.
    /// Implementations are registered under the ContractID:
    ///
    /// "@mozilla.org/network/http-authenticator;1?scheme=<auth-scheme>"
    ///
    /// where <auth-scheme> is the lower-cased value of the authentication scheme
    /// found in the server challenge per the rules of RFC 2617.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("16784db0-fcb1-4352-b0c9-6a3a67e3cf79")]
	public interface nsIHttpAuthenticator
	{
		
		/// <summary>
        /// Upon receipt of a server challenge, this function is called to determine
        /// whether or not the current user identity has been rejected.  If true,
        /// then the user will be prompted by the channel to enter (or revise) their
        /// identity.  Following this, generateCredentials will be called.
        ///
        /// If the IDENTITY_IGNORED auth flag is set, then the aInvalidateIdentity
        /// return value will be ignored, and user prompting will be suppressed.
        ///
        /// @param aChannel
        /// the http channel that received the challenge.
        /// @param aChallenge
        /// the challenge from the WWW-Authenticate/Proxy-Authenticate
        /// server response header.  (possibly from the auth cache.)
        /// @param aProxyAuth
        /// flag indicating whether or not aChallenge is from a proxy.
        /// @param aSessionState
        /// see description below for generateCredentials.
        /// @param aContinuationState
        /// see description below for generateCredentials.
        /// @param aInvalidateIdentity
        /// return value indicating whether or not to prompt the user for a
        /// revised identity.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ChallengeReceived([MarshalAs(UnmanagedType.Interface)] nsIHttpAuthenticableChannel  aChannel, [MarshalAs(UnmanagedType.LPStr)] System.String  aChallenge, System.Boolean  aProxyAuth, [MarshalAs(UnmanagedType.Interface)] ref nsISupports  aSessionState, [MarshalAs(UnmanagedType.Interface)] ref nsISupports  aContinuationState, out System.Boolean  aInvalidatesIdentity);
		
		/// <summary>
        /// Called to generate the authentication credentials for a particular
        /// server/proxy challenge.  This is the value that will be sent back
        /// to the server via an Authorization/Proxy-Authorization header.
        ///
        /// This function may be called using a cached challenge provided the
        /// authenticator sets the REUSABLE_CHALLENGE flag.
        ///
        /// @param aChannel
        /// the http channel requesting credentials
        /// @param aChallenge
        /// the challenge from the WWW-Authenticate/Proxy-Authenticate
        /// server response header.  (possibly from the auth cache.)
        /// @param aProxyAuth
        /// flag indicating whether or not aChallenge is from a proxy.
        /// @param aDomain
        /// string containing the domain name (if appropriate)
        /// @param aUser
        /// string containing the user name
        /// @param aPassword
        /// string containing the password
        /// @param aSessionState
        /// state stored along side the user's identity in the auth cache
        /// for the lifetime of the browser session.  if a new auth cache
        /// entry is created for this challenge, then this parameter will
        /// be null.  on return, the result will be stored in the new auth
        /// cache entry.  this parameter is non-null when an auth cache entry
        /// is being reused.
        /// @param aContinuationState
        /// state held by the channel between consecutive calls to
        /// generateCredentials, assuming multiple calls are required
        /// to authenticate.  this state is held for at most the lifetime of
        /// the channel.
        /// @param aFlags
        /// authenticator may return one of the generate flags bellow.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GenerateCredentials([MarshalAs(UnmanagedType.Interface)] nsIHttpAuthenticableChannel  aChannel, [MarshalAs(UnmanagedType.LPStr)] System.String  aChallenge, System.Boolean  aProxyAuth, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aDomain, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aUser, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aPassword, [MarshalAs(UnmanagedType.Interface)] ref nsISupports  aSessionState, [MarshalAs(UnmanagedType.Interface)] ref nsISupports  aContinuationState, out System.UInt32  aFlags);
		
		/// <summary>
        /// Flags defining various properties of the authenticator.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetAuthFlagsAttribute();
	}
}
