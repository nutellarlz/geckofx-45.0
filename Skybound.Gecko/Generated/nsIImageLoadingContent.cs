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
// Generated by IDLImporter from file nsIImageLoadingContent.idl
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
    /// This interface represents a content node that loads images.  The interface
    /// exists to allow getting information on the images that the content node
    /// loads and to allow registration of observers for the image loads.
    ///
    /// Implementors of this interface should handle all the mechanics of actually
    /// loading an image -- getting the URI, checking with content policies and
    /// the security manager to see whether loading the URI is allowed, performing
    /// the load, firing any DOM events as needed.
    ///
    /// An implementation of this interface may support the concepts of a
    /// "current" image and a "pending" image.  If it does, a request to change
    /// the currently loaded image will start a "pending" request which will
    /// become current only when the image is loaded.  It is the responsibility of
    /// observers to check which request they are getting notifications for.
    ///
    /// Observers added in mid-load will not get any notifications they
    /// missed.  We should NOT freeze this interface without considering
    /// this issue.  (It could be that the image status on imgIRequest is
    /// sufficient, when combined with the imageBlockingStatus information.)
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f7debb84-2854-4731-a57b-1bd752ad71f8")]
	public interface nsIImageLoadingContent : imgIDecoderObserver
	{
		
		/// <summary>
        /// imgIContainerObserver interface
        ///
        /// @author Stuart Parmenter <pavlov@netscape.com>
        /// @version 0.1
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void FrameChanged(imgIRequest aRequest, imgIContainer aContainer, [MarshalAs(UnmanagedType.Interface)] nsIntRect aDirtyRect);
		
		/// <summary>
        /// Load notification.
        ///
        /// called at the same time that nsIRequestObserver::onStartRequest would be
        /// (used only for observers of imgIRequest objects, which are nsIRequests,
        /// not imgIDecoder objects)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest(imgIRequest aRequest);
		
		/// <summary>
        /// Decode notification.
        ///
        /// Called as soon as the image begins getting decoded. This does not include
        /// "header-only" decodes used by decode-on-draw to parse the width/height
        /// out of the image. Thus, it is a decode notification only.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartDecode(imgIRequest aRequest);
		
		/// <summary>
        /// Load notification.
        ///
        /// Called once enough data has been loaded from the network that we were able
        /// to parse the width/height from the image. By the time this callback is been
        /// called, the size has been set on the container and STATUS_SIZE_AVAILABLE
        /// has been set on the associated imgRequest.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartContainer(imgIRequest aRequest, imgIContainer aContainer);
		
		/// <summary>
        /// Decode notification.
        ///
        /// called when each frame is created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartFrame(imgIRequest aRequest, uint aFrame);
		
		/// <summary>
        /// Decode notification.
        ///
        /// called when there is more to paint.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable(imgIRequest aRequest, [MarshalAs(UnmanagedType.U1)] bool aCurrentFrame, [MarshalAs(UnmanagedType.Interface)] nsIntRect aRect);
		
		/// <summary>
        /// Decode notification.
        ///
        /// called when a frame is finished decoding.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopFrame(imgIRequest aRequest, uint aFrame);
		
		/// <summary>
        /// Do not implement this. It is useless and going away.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopContainer(imgIRequest aRequest, imgIContainer aContainer);
		
		/// <summary>
        /// Notification for when an image is known to be animated. This should be
        /// fired at the earliest possible time.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnImageIsAnimated(imgIRequest aRequest);
		
		/// <summary>
        /// In theory a decode notification, but currently a load notification.
        ///
        /// Ideally this would be called when the decode is complete. Unfortunately,
        /// this is currently the only way to signal decoding errors to consumers,
        /// and the only decoding errors that consumers care about (indeed, the only
        /// ones that they're prepared to hear about) are failures to instantiate the
        /// decoder (<img src="foo.html"> for example). Thus, currently this is just
        /// a companion to onStopDecode to signal success or failure. This will be
        /// revisited in bug 505385. If you're thinking of doing something new with
        /// this, please talk to bholley first.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopDecode(imgIRequest aRequest, int status, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string statusArg);
		
		/// <summary>
        /// Load notification.
        ///
        /// called at the same time that nsIRequestObserver::onStopRequest would be
        /// (used only for observers of imgIRequest objects, which are nsIRequests,
        /// not imgIDecoder objects)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest(imgIRequest aRequest, [MarshalAs(UnmanagedType.U1)] bool aIsLastPart);
		
		/// <summary>
        /// Called when the decoded image data is discarded. This means that the frames
        /// no longer exist in decoded form, and any attempt to access or draw the
        /// image will initiate a new series of progressive decode notifications.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDiscard(imgIRequest aRequest);
		
		/// <summary>
        /// loadingEnabled is used to enable and disable loading in
        /// situations where loading images is unwanted.  Note that enabling
        /// loading will *not* automatically trigger an image load.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLoadingEnabledAttribute();
		
		/// <summary>
        /// loadingEnabled is used to enable and disable loading in
        /// situations where loading images is unwanted.  Note that enabling
        /// loading will *not* automatically trigger an image load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aLoadingEnabled);
		
		/// <summary>
        /// Returns the image blocking status (@see nsIContentPolicy).  This
        /// will always be an nsIContentPolicy REJECT_* status for cases when
        /// the image was blocked.  This status always refers to the
        /// CURRENT_REQUEST load.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetImageBlockingStatusAttribute();
		
		/// <summary>
        /// Used to register an image decoder observer.  Typically, this will
        /// be a proxy for a frame that wants to paint the image.
        /// Notifications from ongoing image loads will be passed to all
        /// registered observers.  Notifications for all request types,
        /// current and pending, will be passed through.
        ///
        /// @param aObserver the observer to register
        ///
        /// @throws NS_ERROR_OUT_OF_MEMORY
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObserver(imgIDecoderObserver aObserver);
		
		/// <summary>
        /// Used to unregister an image decoder observer.
        ///
        /// @param aObserver the observer to unregister
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObserver(imgIDecoderObserver aObserver);
		
		/// <summary>
        /// Accessor to get the image requests
        ///
        /// @param aRequestType a value saying which request is wanted
        ///
        /// @return the imgIRequest object (may be null, even when no error
        /// is thrown)
        ///
        /// @throws NS_ERROR_UNEXPECTED if the request type requested is not
        /// known
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIRequest GetRequest(int aRequestType);
		
		/// <summary>
        /// Used to notify the image loading content node that a frame has been
        /// created.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FrameCreated(System.IntPtr aFrame);
		
		/// <summary>
        /// Used to notify the image loading content node that a frame has been
        /// destroyed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FrameDestroyed(System.IntPtr aFrame);
		
		/// <summary>
        /// Used to find out what type of request one is dealing with (eg
        /// which request got passed through to the imgIDecoderObserver
        /// interface of an observer)
        ///
        /// @param aRequest the request whose type we want to know
        ///
        /// @return an enum value saying what type this request is
        ///
        /// @throws NS_ERROR_UNEXPECTED if aRequest is not known
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRequestType(imgIRequest aRequest);
		
		/// <summary>
        /// Gets the URI of the current request, if available.
        /// Otherwise, returns the last URI that this content tried to load, or
        /// null if there haven't been any such attempts.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetCurrentURIAttribute();
		
		/// <summary>
        /// loadImageWithChannel allows data from an existing channel to be
        /// used as the image data for this content node.
        ///
        /// @param aChannel the channel that will deliver the data
        ///
        /// @return a stream listener to pump the image data into
        ///
        /// @see imgILoader::loadImageWithChannel
        ///
        /// @throws NS_ERROR_NULL_POINTER if aChannel is null
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStreamListener LoadImageWithChannel([MarshalAs(UnmanagedType.Interface)] nsIChannel aChannel);
		
		/// <summary>
        /// forceReload forces reloading of the image pointed to by currentURI
        ///
        /// @throws NS_ERROR_NOT_AVAILABLE if there is no current URI to reload
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceReload();
		
		/// <summary>
        /// Enables/disables image state forcing. When |aForce| is PR_TRUE, we force
        /// nsImageLoadingContent::ImageState() to return |aState|. Call again with |aForce|
        /// as PR_FALSE to revert ImageState() to its original behaviour.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceImageState([MarshalAs(UnmanagedType.U1)] bool aForce, ulong aState);
		
		/// <summary>
        /// We need to be notified when our document changes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyOwnerDocumentChanged(System.IntPtr aOldDoc);
	}
	
	/// <summary>nsIImageLoadingContentConsts </summary>
	public class nsIImageLoadingContentConsts
	{
		
		// <summary>
        // Request types.  Image loading content nodes attempt to do atomic
        // image changes when the image url is changed.  This means that
        // when the url changes the new image load will start, but the old
        // image will remain the "current" request until the new image is
        // fully loaded.  At that point, the old "current" request will be
        // discarded and the "pending" request will become "current".
        // </summary>
		public const long UNKNOWN_REQUEST = -1;
		
		// 
		public const long CURRENT_REQUEST = 0;
		
		// 
		public const long PENDING_REQUEST = 1;
	}
}
