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
// Generated by IDLImporter from file nsIFileURL.idl
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
    /// nsIFileURL provides access to the underlying nsIFile object corresponding to
    /// an URL.  The URL scheme need not be file:, since other local protocols may
    /// map URLs to files (e.g., resource:).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7750029c-1b0a-414e-8359-a77f24a2a0a6")]
	public interface nsIFileURL : nsIURL
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
		new void GetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);
		
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
		new void SetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpec);
		
		/// <summary>
        /// The prePath (eg. scheme://user:password@host:port) returns the string
        /// before the path.  This is useful for authentication or managing sessions.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPrePath);
		
		/// <summary>
        /// The Scheme is the protocol to which this URI refers.  The scheme is
        /// restricted to the US-ASCII charset per RFC2396.  Setting this is
        /// highly discouraged outside of a protocol handler implementation, since
        /// that will generally lead to incorrect results.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);
		
		/// <summary>
        /// The Scheme is the protocol to which this URI refers.  The scheme is
        /// restricted to the US-ASCII charset per RFC2396.  Setting this is
        /// highly discouraged outside of a protocol handler implementation, since
        /// that will generally lead to incorrect results.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aScheme);
		
		/// <summary>
        /// The username:password (or username only if value doesn't contain a ':')
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);
		
		/// <summary>
        /// The username:password (or username only if value doesn't contain a ':')
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUserPass);
		
		/// <summary>
        /// The optional username and password, assuming the preHost consists of
        /// username:password.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);
		
		/// <summary>
        /// The optional username and password, assuming the preHost consists of
        /// username:password.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPassword);
		
		/// <summary>
        /// The host:port (or simply the host, if port == -1).
        ///
        /// Characters are NOT escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);
		
		/// <summary>
        /// The host:port (or simply the host, if port == -1).
        ///
        /// Characters are NOT escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostPort);
		
		/// <summary>
        /// The host is the internet domain name to which this URI refers.  It could
        /// be an IPv4 (or IPv6) address literal.  If supported, it could be a
        /// non-ASCII internationalized domain name.
        ///
        /// Characters are NOT escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);
		
		/// <summary>
        /// The host is the internet domain name to which this URI refers.  It could
        /// be an IPv4 (or IPv6) address literal.  If supported, it could be a
        /// non-ASCII internationalized domain name.
        ///
        /// Characters are NOT escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);
		
		/// <summary>
        /// A port value of -1 corresponds to the protocol's default port (eg. -1
        /// implies port 80 for http URIs).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetPortAttribute();
		
		/// <summary>
        /// A port value of -1 corresponds to the protocol's default port (eg. -1
        /// implies port 80 for http URIs).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPortAttribute(int aPort);
		
		/// <summary>
        /// The path, typically including at least a leading '/' (but may also be
        /// empty, depending on the protocol).
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);
		
		/// <summary>
        /// The path, typically including at least a leading '/' (but may also be
        /// empty, depending on the protocol).
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aPath);
		
		/// <summary>
        /// URI equivalence test (not a strict string comparison).
        ///
        /// eg. http://foo.com:80/ == http://foo.com/
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIURI other);
		
		/// <summary>
        /// An optimization to do scheme checks without requiring the users of nsIURI
        /// to GetScheme, thereby saving extra allocating and freeing. Returns true if
        /// the schemes match (case ignored).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool SchemeIs([MarshalAs(UnmanagedType.LPStr)] string scheme);
		
		/// <summary>
        /// Clones the current URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI Clone();
		
		/// <summary>
        /// This method resolves a relative string into an absolute URI string,
        /// using this URI as the base.
        ///
        /// NOTE: some implementations may have no concept of a relative URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase relativePath, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// The URI spec with an ASCII compatible encoding.  Host portion follows
        /// the IDNA draft spec.  Other parts are URL-escaped per the rules of
        /// RFC2396.  The result is strictly ASCII.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAsciiSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiSpec);
		
		/// <summary>
        /// The URI host with an ASCII compatible encoding.  Follows the IDNA
        /// draft spec for converting internationalized domain names (UTF-8) to
        /// ASCII for compatibility with existing internet infrasture.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetAsciiHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aAsciiHost);
		
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
		new void GetOriginCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aOriginCharset);
		
		/// <summary>
        /// Returns the reference portion (the part after the "#") of the URI.
        /// If there isn't one, an empty string is returned.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);
		
		/// <summary>
        /// Returns the reference portion (the part after the "#") of the URI.
        /// If there isn't one, an empty string is returned.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aRef);
		
		/// <summary>
        /// URI equivalence test (not a strict string comparison), ignoring
        /// the value of the .ref member.
        ///
        /// eg. http://foo.com/# == http://foo.com/
        /// http://foo.com/#aaa == http://foo.com/#bbb
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool EqualsExceptRef([MarshalAs(UnmanagedType.Interface)] nsIURI other);
		
		/// <summary>
        /// Clones the current URI, clearing the 'ref' attribute in the clone.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIURI CloneIgnoringRef();
		
		/// <summary>
        /// returns a string for the current URI with the ref element cleared.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSpecIgnoringRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSpecIgnoringRef);
		
		/// <summary>
        /// Returns if there is a reference portion (the part after the "#") of the URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetHasRefAttribute();
		
		/// <summary>
        /// Returns a path including the directory and file portions of a
        /// URL.  For example, the filePath of "http://host/foo/bar.html#baz"
        /// is "/foo/bar.html".
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFilePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilePath);
		
		/// <summary>
        /// Returns a path including the directory and file portions of a
        /// URL.  For example, the filePath of "http://host/foo/bar.html#baz"
        /// is "/foo/bar.html".
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFilePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFilePath);
		
		/// <summary>
        /// Returns the query portion (the part after the "?") of the URL.
        /// If there isn't one, an empty string is returned.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetQueryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aQuery);
		
		/// <summary>
        /// Returns the query portion (the part after the "?") of the URL.
        /// If there isn't one, an empty string is returned.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetQueryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aQuery);
		
		/// <summary>
        /// Returns the directory portion of a URL.  If the URL denotes a path to a
        /// directory and not a file, e.g. http://host/foo/bar/, then the Directory
        /// attribute accesses the complete /foo/bar/ portion, and the FileName is
        /// the empty string. If the trailing slash is omitted, then the Directory
        /// is /foo/ and the file is bar (i.e. this is a syntactic, not a semantic
        /// breakdown of the Path).  And hence don't rely on this for something to
        /// be a definitely be a file. But you can get just the leading directory
        /// portion for sure.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDirectoryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDirectory);
		
		/// <summary>
        /// Returns the directory portion of a URL.  If the URL denotes a path to a
        /// directory and not a file, e.g. http://host/foo/bar/, then the Directory
        /// attribute accesses the complete /foo/bar/ portion, and the FileName is
        /// the empty string. If the trailing slash is omitted, then the Directory
        /// is /foo/ and the file is bar (i.e. this is a syntactic, not a semantic
        /// breakdown of the Path).  And hence don't rely on this for something to
        /// be a definitely be a file. But you can get just the leading directory
        /// portion for sure.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDirectoryAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDirectory);
		
		/// <summary>
        /// Returns the file name portion of a URL.  If the URL denotes a path to a
        /// directory and not a file, e.g. http://host/foo/bar/, then the Directory
        /// attribute accesses the complete /foo/bar/ portion, and the FileName is
        /// the empty string. Note that this is purely based on searching for the
        /// last trailing slash. And hence don't rely on this to be a definite file.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileName);
		
		/// <summary>
        /// Returns the file name portion of a URL.  If the URL denotes a path to a
        /// directory and not a file, e.g. http://host/foo/bar/, then the Directory
        /// attribute accesses the complete /foo/bar/ portion, and the FileName is
        /// the empty string. Note that this is purely based on searching for the
        /// last trailing slash. And hence don't rely on this to be a definite file.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFileNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileName);
		
		/// <summary>
        /// Returns the file basename portion of a filename in a url.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFileBaseNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileBaseName);
		
		/// <summary>
        /// Returns the file basename portion of a filename in a url.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFileBaseNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileBaseName);
		
		/// <summary>
        /// Returns the file extension portion of a filename in a url.  If a file
        /// extension does not exist, the empty string is returned.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFileExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileExtension);
		
		/// <summary>
        /// Returns the file extension portion of a filename in a url.  If a file
        /// extension does not exist, the empty string is returned.
        ///
        /// Some characters may be escaped.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFileExtensionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aFileExtension);
		
		/// <summary>
        /// This method takes a uri and compares the two.  The common uri portion
        /// is returned as a string.  The minimum common uri portion is the
        /// protocol, and any of these if present:  login, password, host and port
        /// If no commonality is found, "" is returned.  If they are identical, the
        /// whole path with file/ref/etc. is returned.  For file uris, it is
        /// expected that the common spec would be at least "file:///" since '/' is
        /// a shared common root.
        ///
        /// Examples:
        /// this.spec               aURIToCompare.spec        result
        /// 1) http://mozilla.org/     http://www.mozilla.org/   ""
        /// 2) http://foo.com/bar/     ftp://foo.com/bar/        ""
        /// 3) http://foo.com:8080/    http://foo.com/bar/       ""
        /// 4) ftp://user@foo.com/     ftp://user:pw@foo.com/    ""
        /// 5) ftp://foo.com/bar/      ftp://foo.com/bar         ftp://foo.com/
        /// 6) ftp://foo.com/bar/      ftp://foo.com/bar/b.html  ftp://foo.com/bar/
        /// 7) http://foo.com/a.htm#i  http://foo.com/b.htm      http://foo.com/
        /// 8) ftp://foo.com/c.htm#i   ftp://foo.com/c.htm       ftp://foo.com/c.htm
        /// 9) file:///a/b/c.html      file:///d/e/c.html        file:///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCommonBaseSpec([MarshalAs(UnmanagedType.Interface)] nsIURI aURIToCompare, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// This method tries to create a string which specifies the location of the
        /// argument relative to |this|.  If the argument and |this| are equal, the
        /// method returns "".  If any of the URIs' scheme, host, userpass, or port
        /// don't match, the method returns the full spec of the argument.
        ///
        /// Examples:
        /// this.spec               aURIToCompare.spec        result
        /// 1) http://mozilla.org/     http://www.mozilla.org/   http://www.mozilla.org/
        /// 2) http://mozilla.org/     http://www.mozilla.org    http://www.mozilla.org/
        /// 3) http://foo.com/bar/     http://foo.com:80/bar/    ""
        /// 4) http://foo.com/         http://foo.com/a.htm#b    a.html#b
        /// 5) http://foo.com/a/b/     http://foo.com/c          ../../c
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetRelativeSpec([MarshalAs(UnmanagedType.Interface)] nsIURI aURIToCompare, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Get/Set nsIFile corresponding to this URL.
        ///
        /// - Getter returns a reference to an immutable object.  Callers must clone
        /// before attempting to modify the returned nsIFile object.  NOTE: this
        /// constraint might not be enforced at runtime, so beware!!
        ///
        /// - Setter clones the nsIFile object (allowing the caller to safely modify
        /// the nsIFile object after setting it on this interface).
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetFileAttribute();
		
		/// <summary>
        /// Get/Set nsIFile corresponding to this URL.
        ///
        /// - Getter returns a reference to an immutable object.  Callers must clone
        /// before attempting to modify the returned nsIFile object.  NOTE: this
        /// constraint might not be enforced at runtime, so beware!!
        ///
        /// - Setter clones the nsIFile object (allowing the caller to safely modify
        /// the nsIFile object after setting it on this interface).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileAttribute([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
	}
}
