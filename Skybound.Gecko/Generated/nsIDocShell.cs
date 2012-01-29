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
// Generated by IDLImporter from file nsIDocShell.idl
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
    /// The nsIDocShell interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0666adf8-8738-4ca7-a917-0348f47d2f40")]
	public interface nsIDocShell
	{
		
		/// <summary>
        /// Loads a given URI.  This will give priority to loading the requested URI
        /// in the object implementing	this interface.  If it can't be loaded here
        /// however, the URL dispatcher will go through its normal process of content
        /// loading.
        ///
        /// @param uri        - The URI to load.
        /// @param loadInfo   - This is the extended load info for this load.  This
        /// most often will be null, but if you need to do
        /// additional setup for this load you can get a loadInfo
        /// object by calling createLoadInfo.  Once you have this
        /// object you can set the needed properties on it and
        /// then pass it to loadURI.
        /// @param aLoadFlags - Flags to modify load behaviour. Flags are defined in
        /// nsIWebNavigation.  Note that using flags outside
        /// LOAD_FLAGS_MASK is only allowed if passing in a
        /// non-null loadInfo.  And even some of those might not
        /// be allowed.  Use at your own risk.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIDocShellLoadInfo loadInfo, uint aLoadFlags, [MarshalAs(UnmanagedType.U1)] bool firstParty);
		
		/// <summary>
        /// Loads a given stream. This will give priority to loading the requested
        /// stream in the object implementing this interface. If it can't be loaded
        /// here however, the URL dispatched will go through its normal process of
        /// content loading.
        ///
        /// @param aStream         - The input stream that provides access to the data
        /// to be loaded.  This must be a blocking, threadsafe
        /// stream implementation.
        /// @param aURI            - The URI representing the stream, or null.
        /// @param aContentType    - The type (MIME) of data being loaded (empty if unknown).
        /// @param aContentCharset - The charset of the data being loaded (empty if unknown).
        /// @param aLoadInfo       - This is the extended load info for this load.  This
        /// most often will be null, but if you need to do
        /// additional setup for this load you can get a
        /// loadInfo object by calling createLoadInfo.  Once
        /// you have this object you can set the needed
        /// properties on it and then pass it to loadStream.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACString aContentType, [MarshalAs(UnmanagedType.LPStruct)] nsACString aContentCharset, [MarshalAs(UnmanagedType.Interface)] nsIDocShellLoadInfo aLoadInfo);
		
		/// <summary>
        /// Loads the given URI.  This method is identical to loadURI(...) except
        /// that its parameter list is broken out instead of being packaged inside
        /// of an nsIDocShellLoadInfo object...
        ///
        /// @param aURI            - The URI to load.
        /// @param aReferrer       - Referring URI
        /// @param aOwner          - Owner (security principal)
        /// @param aInheritOwner   - Flag indicating whether the owner of the current
        /// document should be inherited if aOwner is null.
        /// @param aStopActiveDoc  - Flag indicating whether loading the current
        /// document should be stopped.
        /// @param aWindowTarget   - Window target for the load.
        /// @param aTypeHint       - A hint as to the content-type of the resulting
        /// data.  May be null or empty if no hint.
        /// @param aPostDataStream - Post data stream (if POSTing)
        /// @param aHeadersStream  - Stream containing "extra" request headers...
        /// @param aLoadFlags      - Flags to modify load behaviour. Flags are defined
        /// in nsIWebNavigation.
        /// @param aSHEntry        - Active Session History entry (if loading from SH)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InternalLoad([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, [MarshalAs(UnmanagedType.Interface)] nsISupports aOwner, uint aFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aWindowTarget, [MarshalAs(UnmanagedType.LPStr)] string aTypeHint, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostDataStream, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeadersStream, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry, [MarshalAs(UnmanagedType.U1)] bool firstParty, [MarshalAs(UnmanagedType.Interface)] ref nsIDocShell aDocShell, [MarshalAs(UnmanagedType.Interface)] ref nsIRequest aRequest);
		
		/// <summary>
        /// Do either a history.pushState() or history.replaceState() operation,
        /// depending on the value of aReplace.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddState([MarshalAs(UnmanagedType.Interface)] nsIVariant aData, [MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle, [MarshalAs(UnmanagedType.LPStruct)] nsAString aURL, [MarshalAs(UnmanagedType.U1)] bool aReplace, System.IntPtr jsContext);
		
		/// <summary>
        /// Creates a DocShellLoadInfo object that you can manipulate and then pass
        /// to loadURI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateLoadInfo([MarshalAs(UnmanagedType.Interface)] ref nsIDocShellLoadInfo loadInfo);
		
		/// <summary>
        /// Reset state to a new content model within the current document and the document
        /// viewer.  Called by the document before initiating an out of band document.write().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrepareForNewContentModel();
		
		/// <summary>
        /// For editors and suchlike who wish to change the URI associated with the
        /// document. Note if you want to get the current URI, use the read-only
        /// property on nsIWebNavigation.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
		
		/// <summary>
        /// Notify the associated content viewer and all child docshells that they are
        /// about to be hidden.  If |isUnload| is true, then the document is being
        /// unloaded as well.
        ///
        /// @param isUnload if true, fire the unload event in addition to the pagehide
        /// event.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FirePageHideNotification([MarshalAs(UnmanagedType.U1)] bool isUnload);
		
		/// <summary>
        /// Presentation context for the currently loaded document.  This may be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPresContextAttribute();
		
		/// <summary>
        /// Presentation shell for the currently loaded document.  This may be null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetPresShellAttribute();
		
		/// <summary>
        /// Presentation shell for the oldest document, if this docshell is
        /// currently transitioning between documents.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetEldestPresShellAttribute();
		
		/// <summary>
        /// Content Viewer that is currently loaded for this DocShell.  This may
        /// change as the underlying content changes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetContentViewerAttribute();
		
		/// <summary>
        /// This attribute allows chrome to tie in to handle DOM events that may
        /// be of interest to chrome.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetChromeEventHandlerAttribute();
		
		/// <summary>
        /// This attribute allows chrome to tie in to handle DOM events that may
        /// be of interest to chrome.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChromeEventHandlerAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget aChromeEventHandler);
		
		/// <summary>
        /// The document charset info.  This is used by a load to determine priorities
        /// for charset detection etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetDocumentCharsetInfoAttribute();
		
		/// <summary>
        /// The document charset info.  This is used by a load to determine priorities
        /// for charset detection etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocumentCharsetInfoAttribute(System.IntPtr aDocumentCharsetInfo);
		
		/// <summary>
        /// Whether to allow plugin execution
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowPluginsAttribute();
		
		/// <summary>
        /// Whether to allow plugin execution
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowPluginsAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowPlugins);
		
		/// <summary>
        /// Whether to allow Javascript execution
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowJavascriptAttribute();
		
		/// <summary>
        /// Whether to allow Javascript execution
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowJavascriptAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowJavascript);
		
		/// <summary>
        /// Attribute stating if refresh based redirects can be allowed
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowMetaRedirectsAttribute();
		
		/// <summary>
        /// Attribute stating if refresh based redirects can be allowed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowMetaRedirectsAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowMetaRedirects);
		
		/// <summary>
        /// Attribute stating if it should allow subframes (framesets/iframes) or not
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowSubframesAttribute();
		
		/// <summary>
        /// Attribute stating if it should allow subframes (framesets/iframes) or not
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowSubframesAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowSubframes);
		
		/// <summary>
        /// Attribute stating whether or not images should be loaded.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowImagesAttribute();
		
		/// <summary>
        /// Attribute stating whether or not images should be loaded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowImagesAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowImages);
		
		/// <summary>
        /// Attribute that determines whether DNS prefetch is allowed for this subtree
        /// of the docshell tree.  Defaults to true.  Setting this will make it take
        /// effect starting with the next document loaded in the docshell.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowDNSPrefetchAttribute();
		
		/// <summary>
        /// Attribute that determines whether DNS prefetch is allowed for this subtree
        /// of the docshell tree.  Defaults to true.  Setting this will make it take
        /// effect starting with the next document loaded in the docshell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowDNSPrefetchAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowDNSPrefetch);
		
		/// <summary>
        /// Attribute that determines whether window control (move/resize) is allowed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowWindowControlAttribute();
		
		/// <summary>
        /// Attribute that determines whether window control (move/resize) is allowed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowWindowControlAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowWindowControl);
		
		/// <summary>
        /// Get an enumerator over this docShell and its children.
        ///
        /// @param aItemType  - Only include docShells of this type, or if typeAll,
        /// include all child shells.
        /// Uses types from nsIDocShellTreeItem.
        /// @param aDirection - Whether to enumerate forwards or backwards.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetDocShellEnumerator(int aItemType, int aDirection);
		
		/// <summary>
        /// The type of application that created this window
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetAppTypeAttribute();
		
		/// <summary>
        /// The type of application that created this window
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAppTypeAttribute(uint aAppType);
		
		/// <summary>
        /// certain dochshells (like the message pane)
        /// should not throw up auth dialogs
        /// because it can act as a password trojan
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAllowAuthAttribute();
		
		/// <summary>
        /// certain dochshells (like the message pane)
        /// should not throw up auth dialogs
        /// because it can act as a password trojan
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowAuthAttribute([MarshalAs(UnmanagedType.U1)] bool aAllowAuth);
		
		/// <summary>
        /// Set/Get the document scale factor.  When setting this attribute, a
        /// NS_ERROR_NOT_IMPLEMENTED error may be returned by implementations
        /// not supporting zoom.  Implementations not supporting zoom should return
        /// 1.0 all the time for the Get operation.  1.0 by the way is the default
        /// of zoom.  This means 100% of normal scaling or in other words normal size
        /// no zoom.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetZoomAttribute();
		
		/// <summary>
        /// Set/Get the document scale factor.  When setting this attribute, a
        /// NS_ERROR_NOT_IMPLEMENTED error may be returned by implementations
        /// not supporting zoom.  Implementations not supporting zoom should return
        /// 1.0 all the time for the Get operation.  1.0 by the way is the default
        /// of zoom.  This means 100% of normal scaling or in other words normal size
        /// no zoom.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetZoomAttribute(float aZoom);
		
		/// <summary>
        /// The size, in CSS pixels, of the horizontal margins for the <body> of an
        /// HTML document in this docshel; used to implement the marginwidth attribute
        /// on HTML <frame>/<iframe> elements.  A value smaller than zero indicates
        /// that the attribute was not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMarginWidthAttribute();
		
		/// <summary>
        /// The size, in CSS pixels, of the horizontal margins for the <body> of an
        /// HTML document in this docshel; used to implement the marginwidth attribute
        /// on HTML <frame>/<iframe> elements.  A value smaller than zero indicates
        /// that the attribute was not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginWidthAttribute(int aMarginWidth);
		
		/// <summary>
        /// The size, in CSS pixels, of the vertical margins for the <body> of an HTML
        /// document in this docshel; used to implement the marginheight attribute on
        /// HTML <frame>/<iframe> elements.  A value smaller than zero indicates that
        /// the attribute was not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMarginHeightAttribute();
		
		/// <summary>
        /// The size, in CSS pixels, of the vertical margins for the <body> of an HTML
        /// document in this docshel; used to implement the marginheight attribute on
        /// HTML <frame>/<iframe> elements.  A value smaller than zero indicates that
        /// the attribute was not set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginHeightAttribute(int aMarginHeight);
		
		/// <summary>
        /// Tells the docshell to offer focus to its tree owner.
        /// This is currently only necessary for embedding chrome.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void TabToTreeOwner([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] ref bool tookFocus);
		
		/// <summary>
        /// History.pushState()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetBusyFlagsAttribute();
		
		/// <summary>
        /// attribute to access the loadtype  for the document
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLoadTypeAttribute();
		
		/// <summary>
        /// attribute to access the loadtype  for the document
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadTypeAttribute(uint aLoadType);
		
		/// <summary>
        /// returns true if the docshell is being destroyed, false otherwise
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsBeingDestroyed();
		
		/// <summary>
        /// Returns true if the docshell is currently executing the onLoad Handler
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsExecutingOnLoadHandlerAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetLayoutHistoryStateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLayoutHistoryStateAttribute(System.IntPtr aLayoutHistoryState);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShouldSaveLayoutStateAttribute();
		
		/// <summary>
        /// The SecureBrowserUI object for this docshell.  This is set by XUL
        /// <browser> or nsWebBrowser for their root docshell.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISecureBrowserUI GetSecurityUIAttribute();
		
		/// <summary>
        /// The SecureBrowserUI object for this docshell.  This is set by XUL
        /// <browser> or nsWebBrowser for their root docshell.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSecurityUIAttribute([MarshalAs(UnmanagedType.Interface)] nsISecureBrowserUI aSecurityUI);
		
		/// <summary>
        /// Cancel the XPCOM timers for each meta-refresh URI in this docshell,
        /// and this docshell's children, recursively. The meta-refresh timers can be
        /// restarted using resumeRefreshURIs().  If the timers are already suspended,
        /// this has no effect.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SuspendRefreshURIs();
		
		/// <summary>
        /// Restart the XPCOM timers for each meta-refresh URI in this docshell,
        /// and this docshell's children, recursively.  If the timers are already
        /// running, this has no effect.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResumeRefreshURIs();
		
		/// <summary>
        /// Begin firing WebProgressListener notifications for restoring a page
        /// presentation. |viewer| is the content viewer whose document we are
        /// starting to load.  If null, it defaults to the docshell's current content
        /// viewer, creating one if necessary.  |top| should be true for the toplevel
        /// docshell that is being restored; it will be set to false when this method
        /// is called for child docshells.  This method will post an event to
        /// complete the simulated load after returning to the event loop.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginRestore(System.IntPtr viewer, [MarshalAs(UnmanagedType.U1)] bool top);
		
		/// <summary>
        /// Finish firing WebProgressListener notifications and DOM events for
        /// restoring a page presentation.  This should only be called via
        /// beginRestore().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FinishRestore();
		
		/// <summary>
        ///Track whether we're currently restoring a document presentation. </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRestoringDocumentAttribute();
		
		/// <summary>
        ///attribute to access whether error pages are enabled </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetUseErrorPagesAttribute();
		
		/// <summary>
        ///attribute to access whether error pages are enabled </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUseErrorPagesAttribute([MarshalAs(UnmanagedType.U1)] bool aUseErrorPages);
		
		/// <summary>
        /// Keeps track of the previous SHTransaction index and the current
        /// SHTransaction index at the time that the doc shell begins to load.
        /// Used for ContentViewer eviction.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPreviousTransIndexAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLoadedTransIndexAttribute();
		
		/// <summary>
        /// Notification that entries have been removed from the beginning of a
        /// nsSHistory which has this as its rootDocShell.
        ///
        /// @param numEntries - The number of entries removed
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HistoryPurged(int numEntries);
		
		/// <summary>
        /// Retrieves the WebApps session storage object for the supplied domain.
        /// If it doesn't already exist, a new one will be created.
        ///
        /// @param uri the uri of the storage object to retrieve
        /// @param documentURI new storage will be created with reference to this
        /// document.documentURI that will appear in storage event
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStorage GetSessionStorageForURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.LPStruct)] nsAString documentURI);
		
		/// <summary>
        /// Retrieves the WebApps session storage object for the supplied principal.
        ///
        /// @param principal returns a storage for this principal
        /// @param documentURI new storage will be created with reference to this
        /// document.documentURI that will appear in storage event
        /// @param create If true and a session storage object doesn't
        /// already exist, a new one will be created.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStorage GetSessionStorageForPrincipal([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.LPStruct)] nsAString documentURI, [MarshalAs(UnmanagedType.U1)] bool create);
		
		/// <summary>
        /// Add a WebApps session storage object to the docshell.
        ///
        /// @param principal the principal the storage object is associated with
        /// @param storage the storage object to add
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSessionStorage([MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal, [MarshalAs(UnmanagedType.Interface)] nsIDOMStorage storage);
		
		/// <summary>
        /// Gets the channel for the currently loaded document, if any.
        /// For a new document load, this will be the channel of the previous document
        /// until after OnLocationChange fires.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel GetCurrentDocumentChannelAttribute();
		
		/// <summary>
        /// Set the offset of this child in its container.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChildOffset(uint offset);
		
		/// <summary>
        /// Find out whether the docshell is currently in the middle of a page
        /// transition. This is set just before the pagehide/unload events fire.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInUnloadAttribute();
		
		/// <summary>
        /// Find out if the currently loaded document came from a suspicious channel
        /// (such as a JAR channel where the server-returned content type isn't a
        /// known JAR type).
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetChannelIsUnsafeAttribute();
		
		/// <summary>
        /// Disconnects this docshell's editor from its window, and stores the
        /// editor data in the open document's session history entry.  This
        /// should be called only during page transitions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DetachEditorFromWindow();
		
		/// <summary>
        /// If true, this browser is not visible in the traditional sense, but
        /// is actively being rendered to the screen (ex. painted on a canvas)
        /// and should be treated accordingly.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsOffScreenBrowserAttribute();
		
		/// <summary>
        /// If true, this browser is not visible in the traditional sense, but
        /// is actively being rendered to the screen (ex. painted on a canvas)
        /// and should be treated accordingly.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsOffScreenBrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aIsOffScreenBrowser);
		
		/// <summary>
        /// If the current content viewer isn't initialized for print preview,
        /// it is replaced with one which is and to which an about:blank document
        /// is loaded.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserPrint GetPrintPreviewAttribute();
		
		/// <summary>
        /// Whether this docshell can execute scripts based on its hierarchy.
        /// The rule of thumb here is that we disable js if this docshell or any
        /// of its parents disallow scripting, unless the only reason for js being
        /// disabled in this docshell is a parent docshell having a document that
        /// is in design mode.  In that case, we explicitly allow scripting on the
        /// current docshell.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanExecuteScriptsAttribute();
		
		/// <summary>
        /// Sets whether a docshell is active. An active docshell is one that is
        /// visible, and thus is not a good candidate for certain optimizations
        /// like image frame discarding. Docshells are active unless told otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsActiveAttribute();
		
		/// <summary>
        /// Sets whether a docshell is active. An active docshell is one that is
        /// visible, and thus is not a good candidate for certain optimizations
        /// like image frame discarding. Docshells are active unless told otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsActiveAttribute([MarshalAs(UnmanagedType.U1)] bool aIsActive);
		
		/// <summary>
        /// The ID of the docshell in the session history.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetHistoryIDAttribute();
		
		/// <summary>
        /// Sets whether a docshell is an app tab. An app tab docshell may behave
        /// differently than a non-app tab docshell in some cases, such as when
        /// handling link clicks. Docshells are not app tabs unless told otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsAppTabAttribute();
		
		/// <summary>
        /// Sets whether a docshell is an app tab. An app tab docshell may behave
        /// differently than a non-app tab docshell in some cases, such as when
        /// handling link clicks. Docshells are not app tabs unless told otherwise.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsAppTabAttribute([MarshalAs(UnmanagedType.U1)] bool aIsAppTab);
		
		/// <summary>
        /// Create a new about:blank document and content viewer.
        /// @param aPrincipal the principal to use for the new document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateAboutBlankContentViewer([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal);
	}
}
