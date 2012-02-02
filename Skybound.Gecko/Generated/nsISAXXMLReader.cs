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
// Generated by IDLImporter from file nsISAXXMLReader.idl
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
    /// Interface for reading an XML document using callbacks.
    ///
    /// nsISAXXMLReader is the interface that an XML parser's SAX2
    /// driver must implement.  This interface allows an application to set
    /// and query features and properties in the parser, to register event
    /// handlers for document processing, and to initiate a document
    /// parse.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5556997e-d816-4218-8b54-803d4261206e")]
	public interface nsISAXXMLReader : nsIStreamListener
	{
		
		/// <summary>
        /// Called to signify the beginning of an asynchronous request.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        ///
        /// An exception thrown from onStartRequest has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext);
		
		/// <summary>
        /// Called to signify the end of an asynchronous request.  This
        /// call is always preceded by a call to onStartRequest.
        ///
        /// @param aRequest request being observed
        /// @param aContext user defined context
        /// @param aStatusCode reason for stopping (NS_OK if completed successfully)
        ///
        /// An exception thrown from onStopRequest is generally ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, int aStatusCode);
		
		/// <summary>
        /// Called when the next chunk of data (corresponding to the request) may
        /// be read without blocking the calling thread.  The onDataAvailable impl
        /// must read exactly |aCount| bytes of data before returning.
        ///
        /// @param aRequest request corresponding to the source of the data
        /// @param aContext user defined context
        /// @param aInputStream input stream containing the data chunk
        /// @param aOffset
        /// Number of bytes that were sent in previous onDataAvailable calls
        /// for this request. In other words, the sum of all previous count
        /// parameters.
        /// If that number is greater than or equal to 2^32, this parameter
        /// will be PR_UINT32_MAX (2^32 - 1).
        /// @param aCount number of bytes available in the stream
        ///
        /// NOTE: The aInputStream parameter must implement readSegments.
        ///
        /// An exception thrown from onDataAvailable has the side-effect of
        /// causing the request to be canceled.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aInputStream, uint aOffset, uint aCount);
		
		/// <summary>
        /// The base URI.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetBaseURIAttribute();
		
		/// <summary>
        /// The base URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBaseURIAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aBaseURI);
		
		/// <summary>
        /// If the application does not register a content handler, all
        /// content events reported by the SAX parser will be silently
        /// ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXContentHandler GetContentHandlerAttribute();
		
		/// <summary>
        /// If the application does not register a content handler, all
        /// content events reported by the SAX parser will be silently
        /// ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXContentHandler aContentHandler);
		
		/// <summary>
        /// If the application does not register a DTD handler, all DTD
        /// events reported by the SAX parser will be silently ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXDTDHandler GetDtdHandlerAttribute();
		
		/// <summary>
        /// If the application does not register a DTD handler, all DTD
        /// events reported by the SAX parser will be silently ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDtdHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXDTDHandler aDtdHandler);
		
		/// <summary>
        /// If the application does not register an error handler, all
        /// error events reported by the SAX parser will be silently ignored;
        /// however, normal processing may not continue.  It is highly
        /// recommended that all SAX applications implement an error handler
        /// to avoid unexpected bugs.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXErrorHandler GetErrorHandlerAttribute();
		
		/// <summary>
        /// If the application does not register an error handler, all
        /// error events reported by the SAX parser will be silently ignored;
        /// however, normal processing may not continue.  It is highly
        /// recommended that all SAX applications implement an error handler
        /// to avoid unexpected bugs.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetErrorHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXErrorHandler aErrorHandler);
		
		/// <summary>
        /// If the application does not register a lexical handler, all
        /// lexical events (e.g. startDTD) reported by the SAX parser will be
        /// silently ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISAXLexicalHandler GetLexicalHandlerAttribute();
		
		/// <summary>
        /// If the application does not register a lexical handler, all
        /// lexical events (e.g. startDTD) reported by the SAX parser will be
        /// silently ignored.
        ///
        /// Applications may register a new or different handler in the
        /// middle of a parse, and the SAX parser must begin using the new
        /// handler immediately.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLexicalHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsISAXLexicalHandler aLexicalHandler);
		
		/// <summary>
        /// Set the value of a feature flag. NOT CURRENTLY IMPLEMENTED.
        ///
        /// The feature name is any fully-qualified URI.  It is possible
        /// for an XMLReader to expose a feature value but to be unable to
        /// change the current value.  Some feature values may be immutable
        /// or mutable only in specific contexts, such as before, during, or
        /// after a parse.
        ///
        /// All XMLReaders are required to support setting
        /// http://xml.org/sax/features/namespaces to true and
        /// http://xml.org/sax/features/namespace-prefixes to false.
        ///
        /// @param name String flag for a parser feature.
        /// @param value Turn the feature on/off.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFeature([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.Bool)] bool value);
		
		/// <summary>
        /// Look up the value of a feature flag. NOT CURRENTLY IMPLEMENTED.
        ///
        /// The feature name is any fully-qualified URI.  It is
        /// possible for an XMLReader to recognize a feature name but
        /// temporarily be unable to return its value.
        /// Some feature values may be available only in specific
        /// contexts, such as before, during, or after a parse.
        ///
        /// All XMLReaders are required to recognize the
        /// http://xml.org/sax/features/namespaces and the
        /// http://xml.org/sax/features/namespace-prefixes feature names.
        ///
        /// @param name String flag for a parser feature.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFeature([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        /// Set the value of a property. NOT CURRENTLY IMPLEMENTED.
        ///
        /// The property name is any fully-qualified URI.  It is possible
        /// for an XMLReader to recognize a property name but to be unable to
        /// change the current value.  Some property values may be immutable
        /// or mutable only in specific contexts, such as before, during, or
        /// after a parse.
        ///
        /// XMLReaders are not required to recognize setting any specific
        /// property names, though a core set is defined by SAX2.
        ///
        /// This method is also the standard mechanism for setting
        /// extended handlers.
        ///
        /// @param name String flag for a parser feature
        /// @param value Turn the feature on/off.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name, [MarshalAs(UnmanagedType.Interface)] nsISupports value);
		
		/// <summary>
        /// Look up the value of a property. NOT CURRENTLY IMPLEMENTED.
        ///
        /// The property name is any fully-qualified URI.  It is
        /// possible for an XMLReader to recognize a property name but
        /// temporarily be unable to return its value.
        /// Some property values may be available only in specific
        /// contexts, such as before, during, or after a parse.
        ///
        /// XMLReaders are not required to recognize any specific
        /// property names, though an initial core set is documented for
        /// SAX2.
        ///
        /// Implementors are free (and encouraged) to invent their own properties,
        /// using names built on their own URIs.
        ///
        /// @param name The property name, which is a fully-qualified URI.
        /// @return The current value of the property.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        ///
        /// @param str The UTF16 string to be parsed
        /// @param contentType The content type of the string (see parseFromStream)
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseFromString([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase str, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        ///
        /// @param stream The byte stream whose contents are parsed
        /// @param charset The character set that was used to encode the byte
        /// stream. NULL if not specified.
        /// @param contentType The content type of the string - either text/xml,
        /// application/xml, or application/xhtml+xml.
        /// Must not be NULL.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseFromStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream stream, [MarshalAs(UnmanagedType.LPStr)] string charset, [MarshalAs(UnmanagedType.LPStr)] string contentType);
		
		/// <summary>
        /// Begin an asynchronous parse. This method initializes the parser,
        /// and must be called before any nsIStreamListener methods. It is
        /// then the caller's duty to call nsIStreamListener methods to drive
        /// the parser. Once this method is called, the caller must not call
        /// one of the other parse methods.
        ///
        /// @param observer The nsIRequestObserver to notify upon start or stop.
        /// Can be NULL.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ParseAsync([MarshalAs(UnmanagedType.Interface)] nsIRequestObserver observer);
	}
}
