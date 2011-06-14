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
// Generated by IDLImporter from file nsIXMLHttpRequest.idl
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
	
	
	/// <summary>nsIXMLHttpRequestEventTarget </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dea238a1-240f-45f4-9f07-7769bc69eb76")]
	public interface nsIXMLHttpRequestEventTarget : nsIDOMEventTarget
	{
		
		/// <summary>
        /// This method allows the registration of event listeners on the event target.
        /// If an EventListener is added to an EventTarget while it is processing an
        /// event, it will not be triggered by the current actions but may be
        /// triggered during a later stage of event flow, such as the bubbling phase.
        ///
        /// If multiple identical EventListeners are registered on the same
        /// EventTarget with the same parameters the duplicate instances are
        /// discarded. They do not cause the EventListener to be called twice
        /// and since they are discarded they do not need to be removed with the
        /// removeEventListener method.
        ///
        /// @param   type The event type for which the user is registering
        /// @param   listener The listener parameter takes an interface
        /// implemented by the user which contains the methods
        /// to be called when the event occurs.
        /// @param   useCapture If true, useCapture indicates that the user
        /// wishes to initiate capture. After initiating
        /// capture, all events of the specified type will be
        /// dispatched to the registered EventListener before
        /// being dispatched to any EventTargets beneath them
        /// in the tree. Events which are bubbling upward
        /// through the tree will not trigger an
        /// EventListener designated to use capture.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.Bool)] bool useCapture);
		
		/// <summary>
        /// This method allows the removal of event listeners from the event
        /// target. If an EventListener is removed from an EventTarget while it
        /// is processing an event, it will not be triggered by the current actions.
        /// EventListeners can never be invoked after being removed.
        /// Calling removeEventListener with arguments which do not identify any
        /// currently registered EventListener on the EventTarget has no effect.
        ///
        /// @param   type Specifies the event type of the EventListener being
        /// removed.
        /// @param   listener The EventListener parameter indicates the
        /// EventListener to be removed.
        /// @param   useCapture Specifies whether the EventListener being
        /// removed was registered as a capturing listener or
        /// not. If a listener was registered twice, one with
        /// capture and one without, each must be removed
        /// separately. Removal of a capturing listener does
        /// not affect a non-capturing version of the same
        /// listener, and vice versa.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.Bool)] bool useCapture);
		
		/// <summary>
        /// This method allows the dispatch of events into the implementations
        /// event model. Events dispatched in this manner will have the same
        /// capturing and bubbling behavior as events dispatched directly by the
        /// implementation. The target of the event is the EventTarget on which
        /// dispatchEvent is called.
        ///
        /// @param   evt Specifies the event type, behavior, and contextual
        /// information to be used in processing the event.
        /// @return  Indicates whether any of the listeners which handled the
        /// event called preventDefault. If preventDefault was called
        /// the value is false, else the value is true.
        /// @throws  UNSPECIFIED_EVENT_TYPE_ERR: Raised if the Event's type was
        /// not specified by initializing the event before
        /// dispatchEvent was called. Specification of the Event's
        /// type as null or an empty string will also trigger this
        /// exception.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool DispatchEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent evt);
		
		/// <summary>
        /// event handler attributes
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnabortAttribute();
		
		/// <summary>
        /// event handler attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnabortAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnabort);
		
		/// <summary>Member GetOnerrorAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnerrorAttribute();
		
		/// <summary>Member SetOnerrorAttribute </summary>
		/// <param name='aOnerror'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnerror);
		
		/// <summary>Member GetOnloadAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnloadAttribute();
		
		/// <summary>Member SetOnloadAttribute </summary>
		/// <param name='aOnload'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnload);
		
		/// <summary>Member GetOnloadstartAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnloadstartAttribute();
		
		/// <summary>Member SetOnloadstartAttribute </summary>
		/// <param name='aOnloadstart'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadstartAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnloadstart);
		
		/// <summary>Member GetOnprogressAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnprogressAttribute();
		
		/// <summary>Member SetOnprogressAttribute </summary>
		/// <param name='aOnprogress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnprogress);
		
		/// <summary>Member GetOnloadendAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnloadendAttribute();
		
		/// <summary>Member SetOnloadendAttribute </summary>
		/// <param name='aOnloadend'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadendAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnloadend);
	}
	
	/// <summary>nsIXMLHttpRequestUpload </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("09ff3682-7759-4441-a765-f70e1a1fabcf")]
	public interface nsIXMLHttpRequestUpload : nsIXMLHttpRequestEventTarget
	{
		
		/// <summary>
        /// This method allows the registration of event listeners on the event target.
        /// If an EventListener is added to an EventTarget while it is processing an
        /// event, it will not be triggered by the current actions but may be
        /// triggered during a later stage of event flow, such as the bubbling phase.
        ///
        /// If multiple identical EventListeners are registered on the same
        /// EventTarget with the same parameters the duplicate instances are
        /// discarded. They do not cause the EventListener to be called twice
        /// and since they are discarded they do not need to be removed with the
        /// removeEventListener method.
        ///
        /// @param   type The event type for which the user is registering
        /// @param   listener The listener parameter takes an interface
        /// implemented by the user which contains the methods
        /// to be called when the event occurs.
        /// @param   useCapture If true, useCapture indicates that the user
        /// wishes to initiate capture. After initiating
        /// capture, all events of the specified type will be
        /// dispatched to the registered EventListener before
        /// being dispatched to any EventTargets beneath them
        /// in the tree. Events which are bubbling upward
        /// through the tree will not trigger an
        /// EventListener designated to use capture.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.Bool)] bool useCapture);
		
		/// <summary>
        /// This method allows the removal of event listeners from the event
        /// target. If an EventListener is removed from an EventTarget while it
        /// is processing an event, it will not be triggered by the current actions.
        /// EventListeners can never be invoked after being removed.
        /// Calling removeEventListener with arguments which do not identify any
        /// currently registered EventListener on the EventTarget has no effect.
        ///
        /// @param   type Specifies the event type of the EventListener being
        /// removed.
        /// @param   listener The EventListener parameter indicates the
        /// EventListener to be removed.
        /// @param   useCapture Specifies whether the EventListener being
        /// removed was registered as a capturing listener or
        /// not. If a listener was registered twice, one with
        /// capture and one without, each must be removed
        /// separately. Removal of a capturing listener does
        /// not affect a non-capturing version of the same
        /// listener, and vice versa.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, [MarshalAs(UnmanagedType.Bool)] bool useCapture);
		
		/// <summary>
        /// This method allows the dispatch of events into the implementations
        /// event model. Events dispatched in this manner will have the same
        /// capturing and bubbling behavior as events dispatched directly by the
        /// implementation. The target of the event is the EventTarget on which
        /// dispatchEvent is called.
        ///
        /// @param   evt Specifies the event type, behavior, and contextual
        /// information to be used in processing the event.
        /// @return  Indicates whether any of the listeners which handled the
        /// event called preventDefault. If preventDefault was called
        /// the value is false, else the value is true.
        /// @throws  UNSPECIFIED_EVENT_TYPE_ERR: Raised if the Event's type was
        /// not specified by initializing the event before
        /// dispatchEvent was called. Specification of the Event's
        /// type as null or an empty string will also trigger this
        /// exception.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool DispatchEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent evt);
		
		/// <summary>
        /// event handler attributes
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener GetOnabortAttribute();
		
		/// <summary>
        /// event handler attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnabortAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnabort);
		
		/// <summary>Member GetOnerrorAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener GetOnerrorAttribute();
		
		/// <summary>Member SetOnerrorAttribute </summary>
		/// <param name='aOnerror'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnerror);
		
		/// <summary>Member GetOnloadAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener GetOnloadAttribute();
		
		/// <summary>Member SetOnloadAttribute </summary>
		/// <param name='aOnload'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnloadAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnload);
		
		/// <summary>Member GetOnloadstartAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener GetOnloadstartAttribute();
		
		/// <summary>Member SetOnloadstartAttribute </summary>
		/// <param name='aOnloadstart'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnloadstartAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnloadstart);
		
		/// <summary>Member GetOnprogressAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener GetOnprogressAttribute();
		
		/// <summary>Member SetOnprogressAttribute </summary>
		/// <param name='aOnprogress'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnprogress);
		
		/// <summary>Member GetOnloadendAttribute </summary>
		/// <returns>A nsIDOMEventListener</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventListener GetOnloadendAttribute();
		
		/// <summary>Member SetOnloadendAttribute </summary>
		/// <param name='aOnloadend'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnloadendAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnloadend);
	}
	
	/// <summary>
    /// Mozilla's XMLHttpRequest is modelled after Microsoft's IXMLHttpRequest
    /// object. The goal has been to make Mozilla's version match Microsoft's
    /// version as closely as possible, but there are bound to be some differences.
    ///
    /// In general, Microsoft's documentation for IXMLHttpRequest can be used.
    /// Mozilla's interface definitions provide some additional documentation. The
    /// web page to look at is http://www.mozilla.org/xmlextras/
    ///
    /// Mozilla's XMLHttpRequest object can be created in JavaScript like this:
    /// new XMLHttpRequest()
    /// compare to Internet Explorer:
    /// new ActiveXObject("Msxml2.XMLHTTP")
    ///
    /// From JavaScript, the methods and properties visible in the XMLHttpRequest
    /// object are a combination of nsIXMLHttpRequest and nsIJSXMLHttpRequest;
    /// there is no need to differentiate between those interfaces.
    ///
    /// From native code, the way to set up onload and onerror handlers is a bit
    /// different. Here is a comment from Johnny Stenback <jst@netscape.com>:
    ///
    /// The mozilla implementation of nsIXMLHttpRequest implements the interface
    /// nsIDOMEventTarget and that's how you're supported to add event listeners.
    /// Try something like this:
    ///
    /// nsCOMPtr<nsIDOMEventTarget> target(do_QueryInterface(myxmlhttpreq));
    ///
    /// target->AddEventListener(NS_LITERAL_STRING("load"), mylistener,
    /// PR_FALSE)
    ///
    /// where mylistener is your event listener object that implements the
    /// interface nsIDOMEventListener.
    ///
    /// The 'onload', 'onerror', and 'onreadystatechange' attributes moved to
    /// nsIJSXMLHttpRequest, but if you're coding in C++ you should avoid using
    /// those.
    ///
    /// Conclusion: Do not use event listeners on XMLHttpRequest from C++, unless
    /// you're aware of all the security implications.  And then think twice about
    /// it.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("af62a870-820c-4981-96a3-28ab17b779e1")]
	public interface nsIXMLHttpRequest
	{
		
		/// <summary>
        /// The request uses a channel in order to perform the
        /// request.  This attribute represents the channel used
        /// for the request.  NULL if the channel has not yet been
        /// created.
        ///
        /// In a multipart request case, this is the initial channel, not the
        /// different parts in the multipart request.
        ///
        /// Mozilla only. Requires elevated privileges to access.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel GetChannelAttribute();
		
		/// <summary>
        /// The response to the request is parsed as if it were a
        /// text/xml stream. This attributes represents the response as
        /// a DOM Document object. NULL if the request is unsuccessful or
        /// has not yet been sent.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetResponseXMLAttribute();
		
		/// <summary>
        /// The response to the request as text.
        /// NULL if the request is unsuccessful or
        /// has not yet been sent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResponseTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aResponseText);
		
		/// <summary>
        ///ArrayBuffer </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetMozResponseArrayBufferAttribute();
		
		/// <summary>
        /// The status of the response to the request for HTTP requests.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetStatusAttribute();
		
		/// <summary>
        /// The string representing the status of the response for
        /// HTTP requests.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aStatusText);
		
		/// <summary>
        /// If the request has been sent already, this method will
        /// abort the request.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Abort();
		
		/// <summary>
        /// Returns all of the response headers as a string for HTTP
        /// requests.
        ///
        /// Note that this will return all the headers from the *current*
        /// part of a multipart request, not from the original channel.
        ///
        /// @returns A string containing all of the response headers.
        /// NULL if the response has not yet been received.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetAllResponseHeaders();
		
		/// <summary>
        /// Returns the text of the header with the specified name for
        /// HTTP requests.
        ///
        /// @param header The name of the header to retrieve
        /// @returns A string containing the text of the header specified.
        /// NULL if the response has not yet been received or the
        /// header does not exist in the response.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetResponseHeader([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String header);
		
		/// <summary>
        /// Meant to be a script-only method for initializing a request.
        ///
        /// If there is an "active" request (that is, if open() has been called
        /// already), this is equivalent to calling abort() and then open().
        ///
        /// @param method The HTTP method - either "POST" or "GET". Ignored
        /// if the URL is not a HTTP URL.
        /// @param url The URL to which to send the request.
        /// @param async (optional) Whether the request is synchronous or
        /// asynchronous i.e. whether send returns only after
        /// the response is received or if it returns immediately after
        /// sending the request. In the latter case, notification
        /// of completion is sent through the event listeners.
        /// The default value is true.
        /// This argument must be true if the multipart
        /// attribute has been set to true, or an exception will
        /// be thrown.
        /// @param user (optional) A username for authentication if necessary.
        /// The default value is the empty string
        /// @param password (optional) A password for authentication if necessary.
        /// The default value is the empty string
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String method, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String url, [MarshalAs(UnmanagedType.Bool)] bool async, [MarshalAs(UnmanagedType.LPStruct)] nsAString user, [MarshalAs(UnmanagedType.LPStruct)] nsAString password);
		
		/// <summary>
        /// Sends the request. If the request is asynchronous, returns
        /// immediately after sending the request. If it is synchronous
        /// returns only after the response has been received.
        ///
        /// All event listeners must be set before calling send().
        ///
        /// After the initial response, all event listeners will be cleared.
        /// // XXXbz what does that mean, exactly?
        ///
        /// @param body Either an instance of nsIDOMDocument, nsIInputStream
        /// or a string (nsISupportsString in the native calling
        /// case). This is used to populate the body of the
        /// HTTP request if the HTTP request method is "POST".
        /// If the parameter is a nsIDOMDocument, it is serialized.
        /// If the parameter is a nsIInputStream, then it must be
        /// compatible with nsIUploadChannel.setUploadStream, and a
        /// Content-Length header will be added to the HTTP request
        /// with a value given by nsIInputStream.available.  Any
        /// headers included at the top of the stream will be
        /// treated as part of the message body.  The MIME type of
        /// the stream should be specified by setting the Content-
        /// Type header via the setRequestHeader method before
        /// calling send.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Send([MarshalAs(UnmanagedType.Interface)] nsIVariant body);
		
		/// <summary>
        /// A variant of the send() method used to send binary data.
        ///
        /// @param body The request body as a DOM string.  The string data will be
        /// converted to a single-byte string by truncation (i.e., the
        /// high-order byte of each character will be discarded).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendAsBinary([MarshalAs(UnmanagedType.LPStruct)] nsAString body);
		
		/// <summary>
        /// Sets a HTTP request header for HTTP requests. You must call open
        /// before setting the request headers.
        ///
        /// @param header The name of the header to set in the request.
        /// @param value The body of the header.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRequestHeader([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String header, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String value);
		
		/// <summary>
        /// The state of the request.
        ///
        /// Possible values:
        /// 0 UNINITIALIZED open() has not been called yet.
        /// 1 LOADING       send() has not been called yet.
        /// 2 LOADED        send() has been called, headers and status are available.
        /// 3 INTERACTIVE   Downloading, responseText holds the partial data.
        /// 4 COMPLETED     Finished with all operations.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetReadyStateAttribute();
		
		/// <summary>
        /// Override the mime type returned by the server (if any). This may
        /// be used, for example, to force a stream to be treated and parsed
        /// as text/xml, even if the server does not report it as such. This
        /// must be done before the <code>send</code> method is invoked.
        ///
        /// @param mimetype The type used to override that returned by the server
        /// (if any).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OverrideMimeType([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String mimetype);
		
		/// <summary>
        /// Set to true if the response is expected to be a stream of
        /// possibly multiple (XML) documents. If set to true, the content
        /// type of the initial response must be multipart/x-mixed-replace or
        /// an error will be triggerd. All requests must be asynchronous.
        ///
        /// This enables server push. For each XML document that's written to
        /// this request, a new XML DOM document is created and the onload
        /// handler is called inbetween documents. Note that when this is
        /// set, the onload handler and other event handlers are not reset
        /// after the first XML document is loaded, and the onload handler
        /// will be called as each part of the response is received.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMultipartAttribute();
		
		/// <summary>
        /// Set to true if the response is expected to be a stream of
        /// possibly multiple (XML) documents. If set to true, the content
        /// type of the initial response must be multipart/x-mixed-replace or
        /// an error will be triggerd. All requests must be asynchronous.
        ///
        /// This enables server push. For each XML document that's written to
        /// this request, a new XML DOM document is created and the onload
        /// handler is called inbetween documents. Note that when this is
        /// set, the onload handler and other event handlers are not reset
        /// after the first XML document is loaded, and the onload handler
        /// will be called as each part of the response is received.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMultipartAttribute([MarshalAs(UnmanagedType.Bool)] bool aMultipart);
		
		/// <summary>
        /// Set to true if this is a background service request. This will
        /// prevent a load group being associated with the request, and
        /// suppress any security dialogs from being shown * to the user.
        /// In the cases where one of those dialogs would be shown, the request
        /// will simply fail instead.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMozBackgroundRequestAttribute();
		
		/// <summary>
        /// Set to true if this is a background service request. This will
        /// prevent a load group being associated with the request, and
        /// suppress any security dialogs from being shown * to the user.
        /// In the cases where one of those dialogs would be shown, the request
        /// will simply fail instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMozBackgroundRequestAttribute([MarshalAs(UnmanagedType.Bool)] bool aMozBackgroundRequest);
		
		/// <summary>
        /// When set to true attempts to make cross-site Access-Control requests
        /// with credentials such as cookies and authorization headers.
        ///
        /// Never affects same-site requests.
        ///
        /// Defaults to false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetWithCredentialsAttribute();
		
		/// <summary>
        /// When set to true attempts to make cross-site Access-Control requests
        /// with credentials such as cookies and authorization headers.
        ///
        /// Never affects same-site requests.
        ///
        /// Defaults to false.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWithCredentialsAttribute([MarshalAs(UnmanagedType.Bool)] bool aWithCredentials);
		
		/// <summary>
        /// Initialize the object for use from C++ code with the principal, script
        /// context, and owner window that should be used.
        ///
        /// @param principal The principal to use for the request. This must not be
        /// null.
        /// @param scriptContext The script context to use for the request. May be
        /// null.
        /// @param ownerWindow The associated window for the request. May be null.
        /// @param baseURI The base URI to use when resolving relative URIs. May be
        /// null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, System.IntPtr scriptContext, System.IntPtr ownerWindow, [MarshalAs(UnmanagedType.Interface)] nsIURI baseURI);
		
		/// <summary>
        /// Upload process can be tracked by adding event listener to |upload|.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXMLHttpRequestUpload GetUploadAttribute();
		
		/// <summary>
        /// Meant to be a script-only mechanism for setting a callback function.
        /// The attribute is expected to be JavaScript function object. When the
        /// readyState changes, the callback function will be called.
        /// This attribute should not be used from native code!!
        ///
        /// After the initial response, all event listeners will be cleared.
        /// // XXXbz what does that mean, exactly?
        ///
        /// Call open() before setting an onreadystatechange listener.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnreadystatechangeAttribute();
		
		/// <summary>
        /// Meant to be a script-only mechanism for setting a callback function.
        /// The attribute is expected to be JavaScript function object. When the
        /// readyState changes, the callback function will be called.
        /// This attribute should not be used from native code!!
        ///
        /// After the initial response, all event listeners will be cleared.
        /// // XXXbz what does that mean, exactly?
        ///
        /// Call open() before setting an onreadystatechange listener.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnreadystatechangeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnreadystatechange);
	}
	
	/// <summary>nsIXHRSendable </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("840d0d00-e83e-4a29-b3c7-67e96e90a499")]
	public interface nsIXHRSendable
	{
		
		/// <summary>Member GetSendInfo </summary>
		/// <param name='body'> </param>
		/// <param name='contentType'> </param>
		/// <param name='charset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSendInfo([MarshalAs(UnmanagedType.Interface)] out nsIInputStream body, [MarshalAs(UnmanagedType.LPStruct)] nsAString contentType, [MarshalAs(UnmanagedType.LPStruct)] nsAString charset);
	}
	
	/// <summary>
    /// @deprecated
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("423fdd3d-41c9-4149-8fe5-b14a1d3912a0")]
	public interface nsIJSXMLHttpRequest
	{
		
		/// <summary>
        /// Meant to be a script-only mechanism for setting an upload progress event
        /// listener.
        /// This attribute should not be used from native code!!
        /// This event listener may be called multiple times during the upload..
        ///
        /// After the initial response, all event listeners will be cleared.
        /// // XXXbz what does that mean, exactly?
        ///
        /// This event listener must be set BEFORE calling open().
        ///
        /// Mozilla only.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener GetOnuploadprogressAttribute();
		
		/// <summary>
        /// Meant to be a script-only mechanism for setting an upload progress event
        /// listener.
        /// This attribute should not be used from native code!!
        /// This event listener may be called multiple times during the upload..
        ///
        /// After the initial response, all event listeners will be cleared.
        /// // XXXbz what does that mean, exactly?
        ///
        /// This event listener must be set BEFORE calling open().
        ///
        /// Mozilla only.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnuploadprogressAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener aOnuploadprogress);
	}
}
