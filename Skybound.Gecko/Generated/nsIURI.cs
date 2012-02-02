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
// Generated by IDLImporter from file nsIURI.idl
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
	
	
	/// <summary>
    /// nsIURI - interface for an uniform resource identifier w/ i18n support.
    ///
    /// AUTF8String attributes may contain unescaped UTF-8 characters.
    /// Consumers should be careful to escape the UTF-8 strings as necessary, but
    /// should always try to "display" the UTF-8 version as provided by this
    /// interface.
    ///
    /// AUTF8String attributes may also contain escaped characters.
    ///
    /// Unescaping URI segments is unadvised unless there is intimate
    /// knowledge of the underlying charset or there is no plan to display (or
    /// otherwise enforce a charset on) the resulting URI substring.
    ///
    /// The correct way to create an nsIURI from a string is via
    /// nsIIOService.newURI.
    ///
    /// NOTE: nsBinaryInputStream::ReadObject contains a hackaround to intercept the
    /// old (pre-gecko6) nsIURI IID and swap in the current IID instead, in order
    /// for sessionstore to work after an upgrade.  If this IID is revved further,
    /// we will need to add additional checks there for all intermediate IIDs, until
    /// nsPrincipal is fixed to serialize its URIs as nsISupports (bug 662693).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("395fe045-7d18-4adb-a3fd-af98c8a1af11")]
	public interface nsIURI
	{
		
		/// <summary>
        /// Returns a string representation of the URI. Setting the spec causes
        /// the new spec to be parsed per the rules for the scheme the URI
        /// currently has.  In particular, setting the spec to a URI string with a
        /// different scheme will generally produce incorrect results; no one
        /// outside of a protocol handler implementation should be doing that.  If
        /// the URI stores information from the nsIIOService.newURI call used to
        /// create it other than just the parsed string, then behavior of this
        /// information on setting the spec attribute is undefined.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);
		
		/// <summary>
        /// Returns a string representation of the URI. Setting the spec causes
        /// the new spec to be parsed per the rules for the scheme the URI
        /// currently has.  In particular, setting the spec to a URI string with a
        /// different scheme will generally produce incorrect results; no one
        /// outside of a protocol handler implementation should be doing that.  If
        /// the URI stores information from the nsIIOService.newURI call used to
        /// create it other than just the parsed string, then behavior of this
        /// information on setting the spec attribute is undefined.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);
		
		/// <summary>
        /// The prePath (eg. scheme://user:password@host:port) returns the string
        /// before the path.  This is useful for authentication or managing sessions.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPrePath);
		
		/// <summary>
        /// The Scheme is the protocol to which this URI refers.  The scheme is
        /// restricted to the US-ASCII charset per RFC2396.  Setting this is
        /// highly discouraged outside of a protocol handler implementation, since
        /// that will generally lead to incorrect results.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);
		
		/// <summary>
        /// The Scheme is the protocol to which this URI refers.  The scheme is
        /// restricted to the US-ASCII charset per RFC2396.  Setting this is
        /// highly discouraged outside of a protocol handler implementation, since
        /// that will generally lead to incorrect results.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);
		
		/// <summary>
        /// The username:password (or username only if value doesn't contain a ':')
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);
		
		/// <summary>
        /// The username:password (or username only if value doesn't contain a ':')
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);
		
		/// <summary>
        /// The optional username and password, assuming the preHost consists of
        /// username:password.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);
		
		/// <summary>
        /// The optional username and password, assuming the preHost consists of
        /// username:password.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);
		
		/// <summary>
        /// The host:port (or simply the host, if port == -1).
        ///
        /// Characters are NOT escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);
		
		/// <summary>
        /// The host:port (or simply the host, if port == -1).
        ///
        /// Characters are NOT escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);
		
		/// <summary>
        /// The host is the internet domain name to which this URI refers.  It could
        /// be an IPv4 (or IPv6) address literal.  If supported, it could be a
        /// non-ASCII internationalized domain name.
        ///
        /// Characters are NOT escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);
		
		/// <summary>
        /// The host is the internet domain name to which this URI refers.  It could
        /// be an IPv4 (or IPv6) address literal.  If supported, it could be a
        /// non-ASCII internationalized domain name.
        ///
        /// Characters are NOT escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);
		
		/// <summary>
        /// A port value of -1 corresponds to the protocol's default port (eg. -1
        /// implies port 80 for http URIs).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPortAttribute();
		
		/// <summary>
        /// A port value of -1 corresponds to the protocol's default port (eg. -1
        /// implies port 80 for http URIs).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPortAttribute(int aPort);
		
		/// <summary>
        /// The path, typically including at least a leading '/' (but may also be
        /// empty, depending on the protocol).
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);
		
		/// <summary>
        /// The path, typically including at least a leading '/' (but may also be
        /// empty, depending on the protocol).
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);
		
		/// <summary>
        /// URI equivalence test (not a strict string comparison).
        ///
        /// eg. http://foo.com:80/ == http://foo.com/
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIURI other);
		
		/// <summary>
        /// An optimization to do scheme checks without requiring the users of nsIURI
        /// to GetScheme, thereby saving extra allocating and freeing. Returns true if
        /// the schemes match (case ignored).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SchemeIs([MarshalAs(UnmanagedType.LPStr)] string scheme);
		
		/// <summary>
        /// Clones the current URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI Clone();
		
		/// <summary>
        /// This method resolves a relative string into an absolute URI string,
        /// using this URI as the base.
        ///
        /// NOTE: some implementations may have no concept of a relative URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase relativePath, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// The URI spec with an ASCII compatible encoding.  Host portion follows
        /// the IDNA draft spec.  Other parts are URL-escaped per the rules of
        /// RFC2396.  The result is strictly ASCII.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsciiSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiSpec);
		
		/// <summary>
        /// The URI host with an ASCII compatible encoding.  Follows the IDNA
        /// draft spec for converting internationalized domain names (UTF-8) to
        /// ASCII for compatibility with existing internet infrasture.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsciiHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiHost);
		
		/// <summary>
        /// The charset of the document from which this URI originated.  An empty
        /// value implies UTF-8.
        ///
        /// If this value is something other than UTF-8 then the URI components
        /// (e.g., spec, prePath, username, etc.) will all be fully URL-escaped.
        /// Otherwise, the URI components may contain unescaped multibyte UTF-8
        /// characters.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginCharset);
		
		/// <summary>
        /// Returns the reference portion (the part after the "#") of the URI.
        /// If there isn't one, an empty string is returned.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);
		
		/// <summary>
        /// Returns the reference portion (the part after the "#") of the URI.
        /// If there isn't one, an empty string is returned.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);
		
		/// <summary>
        /// URI equivalence test (not a strict string comparison), ignoring
        /// the value of the .ref member.
        ///
        /// eg. http://foo.com/# == http://foo.com/
        /// http://foo.com/#aaa == http://foo.com/#bbb
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool EqualsExceptRef([MarshalAs(UnmanagedType.Interface)] nsIURI other);
		
		/// <summary>
        /// Clones the current URI, clearing the 'ref' attribute in the clone.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI CloneIgnoringRef();
		
		/// <summary>
        /// returns a string for the current URI with the ref element cleared.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpecIgnoringRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpecIgnoringRef);
		
		/// <summary>
        /// Returns if there is a reference portion (the part after the "#") of the URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetHasRefAttribute();
	}
}
