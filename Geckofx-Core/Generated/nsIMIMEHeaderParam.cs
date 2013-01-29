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
// Generated by IDLImporter from file nsIMIMEHeaderParam.idl
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
    /// This interface allows any module to access the routine
    /// for MIME header parameter parsing (RFC 2231/5987)
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ddbbdfb8-a1c0-4dd5-a31b-5d2a7a3bb6ec")]
	public interface nsIMIMEHeaderParam
	{
		
		/// <summary>
        /// Given the value of a single header field  (such as
        /// Content-Disposition and Content-Type) and the name of a parameter
        /// (e.g. filename, name, charset), returns the value of the parameter.
        /// The value is obtained by decoding RFC 2231-style encoding,
        /// RFC 2047-style encoding, and converting to UniChar(UTF-16)
        /// from charset specified in RFC 2231/2047 encoding, UTF-8,
        /// <code>aFallbackCharset</code>, the locale charset as fallback if
        /// <code>TryLocaleCharset</code> is set, and null-padding as last resort
        /// if all else fails.
        ///
        /// <p>
        /// This method internally invokes <code>getParameterInternal</code>,
        /// However, it does not stop at decoding RFC 2231 (the task for
        /// <code>getParameterInternal</code> but tries to cope
        /// with several non-standard-compliant cases mentioned below.
        ///
        /// <p>
        /// Note that a lot of MUAs and HTTP servers put RFC 2047-encoded parameters
        /// in mail headers and HTTP headers. Unfortunately, this includes Mozilla
        /// as of 2003-05-30. Even more standard-ignorant MUAs, web servers and
        /// application servers put 'raw 8bit characters'. This will try to cope
        /// with all these cases as gracefully as possible. Additionally, it
        /// returns the language tag if the parameter is encoded per RFC 2231 and
        /// includes lang.
        ///
        ///
        ///
        /// @param  aHeaderVal        a header string to get the value of a parameter
        /// from.
        /// @param  aParamName        the name of a MIME header parameter (e.g.
        /// filename, name, charset). If empty,  returns
        /// the first (possibly) _unnamed_ 'parameter'.
        /// @param  aFallbackCharset  fallback charset to try if  the string after
        /// RFC 2231/2047 decoding or the raw 8bit
        /// string is not UTF-8
        /// @param  aTryLocaleCharset If set, makes yet another attempt
        /// with the locale charset.
        /// @param  aLang             If non-null, assigns it to a pointer
        /// to a string containing the value of language
        /// obtained from RFC 2231 parsing. Caller has to
        /// nsMemory::Free it.
        /// @return the value of <code>aParamName</code> in Unichar(UTF-16).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetParameter([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeaderVal, [MarshalAs(UnmanagedType.LPStr)] string aParamName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFallbackCharset, [MarshalAs(UnmanagedType.U1)] bool aTryLocaleCharset, [MarshalAs(UnmanagedType.LPStr)] ref string aLang, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Like getParameter, but using RFC 5987 instead of 2231.  This removes
        /// support for header parameter continuations (foo*0, foo*1, etc).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetParameter5987([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aHeaderVal, [MarshalAs(UnmanagedType.LPStr)] string aParamName, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aFallbackCharset, [MarshalAs(UnmanagedType.U1)] bool aTryLocaleCharset, [MarshalAs(UnmanagedType.LPStr)] ref string aLang, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Given the value of a header field parameter using the encoding
        /// defined in RFC 5987, decode the value into a Unicode string, and extract
        /// the optional language parameter.
        ///
        /// <p>
        /// This function is purposefully picky; it will abort for all (most?)
        /// invalid inputs. This is by design. In particular, it does not support
        /// any character encodings other than UTF-8, in order not to promote
        /// non-interoperable usage.
        ///
        /// <p>
        /// This code is currently not used inside nsMIMEHeaderParamImpl, but
        /// might be in the future. New code that needs RFC2231/5987
        /// encoding should use this one.
        ///
        /// @param  aParamVal         a header field parameter to decode.
        /// @param  aLang             will be set to the language part (possibly
        /// empty).
        /// @return the decoded parameter value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecodeRFC5987Param([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParamVal, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aLang, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Given the value of a single header field  (such as
        /// Content-Disposition and Content-Type) and the name of a parameter
        /// (e.g. filename, name, charset), returns the value of the parameter
        /// after decoding RFC 2231-style encoding.
        /// <p>
        /// For <strong>internal use only</strong>. The only other place where
        /// this needs to be  invoked  is  |MimeHeaders_get_parameter| in
        /// mailnews/mime/src/mimehdrs.cpp defined as
        /// char * MimeHeaders_get_parameter (const char *header_value,
        /// const char *parm_name,
        /// char **charset, char **language)
        ///
        /// Otherwise, this method would have been made static.
        ///
        /// @param  aHeaderVal  a header string to get the value of a parameter from.
        /// @param  aParamName  the name of a MIME header parameter (e.g.
        /// filename, name, charset). If empty,  returns
        /// the first (possibly) _unnamed_ 'parameter'.
        /// @param  aCharset    If non-null, it gets assigned a new pointer
        /// to a string containing the value of charset obtained
        /// from RFC 2231 parsing. Caller has to nsMemory::Free it.
        /// @param  aLang       If non-null, it gets assigned a new pointer
        /// to a string containing the value of language obtained
        /// from RFC 2231 parsing. Caller has to nsMemory::Free it.
        /// @return             the value of <code>aParamName</code> after
        /// RFC 2231 decoding but without charset conversion.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetParameterInternal([MarshalAs(UnmanagedType.LPStr)] string aHeaderVal, [MarshalAs(UnmanagedType.LPStr)] string aParamName, [MarshalAs(UnmanagedType.LPStr)] ref string aCharset, [MarshalAs(UnmanagedType.LPStr)] ref string aLang);
		
		/// <summary>
        /// Given a header value, decodes RFC 2047-style encoding and
        /// returns the decoded header value in UTF-8 if either it's
        /// RFC-2047-encoded or aDefaultCharset is given. Otherwise,
        /// returns the input header value (in whatever encoding)
        /// as it is except that  RFC 822 (using backslash) quotation and
        /// CRLF (if aEatContinuation is set) are stripped away
        /// <p>
        /// For internal use only. The only other place where this needs to be
        /// invoked  is  <code>MIME_DecodeMimeHeader</code> in
        /// mailnews/mime/src/mimehdrs.cpp defined as
        /// char * Mime_DecodeMimeHeader(char *header_val, const char *charset,
        /// bool override, bool eatcontinuation)
        ///
        /// @param aHeaderVal       a header value to decode
        /// @param aDefaultCharset  MIME charset to use in place of MIME charset
        /// specified in RFC 2047 style encoding
        /// when <code>aOverrideCharset</code> is set.
        /// @param aOverrideCharset When set, overrides MIME charset specified
        /// in RFC 2047 style encoding with <code>aDefaultCharset</code>
        /// @param aEatContinuation When set, removes CR/LF
        /// @return                 decoded header value
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecodeRFC2047Header([MarshalAs(UnmanagedType.LPStr)] string aHeaderVal, [MarshalAs(UnmanagedType.LPStr)] string aDefaultCharset, [MarshalAs(UnmanagedType.U1)] bool aOverrideCharset, [MarshalAs(UnmanagedType.U1)] bool aEatContinuation, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// Given a header parameter, decodes RFC 2047 style encoding (if it's
        /// not obtained from RFC 2231 encoding),  converts it to
        /// UTF-8 and returns the result in UTF-8 if an attempt to extract
        /// charset info. from a few different sources succeeds.
        /// Otherwise,  returns the input header value (in whatever encoding)
        /// as it is except that  RFC 822 (using backslash) quotation is
        /// stripped off.
        /// <p>
        /// For internal use only. The only other place where this needs to be
        /// invoked  is  <code>mime_decode_filename</code> in
        /// mailnews/mime/src/mimehdrs.cpp defined as
        /// char * mime_decode_filename(char *name, const char *charset,
        /// MimeDisplayOptions *opt)
        ///
        /// @param aParamValue      the value of a parameter to decode and convert
        /// @param aCharset         charset obtained from RFC 2231 decoding  in which
        /// <code>aParamValue</code> is encoded. If null,
        /// indicates that it needs to try RFC 2047, instead.
        /// @param aDefaultCharset  MIME charset to use when aCharset is null and
        /// cannot be obtained per RFC 2047 (most likely
        /// because 'bare' string is  used.)  Besides, it
        /// overrides aCharset/MIME charset obtained from
        /// RFC 2047 if <code>aOverrideCharset</code>  is set.
        /// @param aOverrideCharset When set, overrides MIME charset specified
        /// in RFC 2047 style encoding with
        /// <code>aDefaultCharset</code>
        /// @return                 decoded parameter
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DecodeParameter([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aParamValue, [MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.LPStr)] string aDefaultCharset, [MarshalAs(UnmanagedType.U1)] bool aOverrideCharset, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
	}
}
