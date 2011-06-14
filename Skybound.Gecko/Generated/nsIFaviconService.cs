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
// Generated by IDLImporter from file nsIFaviconService.idl
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
	
	
	/// <summary>nsIFaviconService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2cf188f4-3c96-4bca-b668-36b25aaf7c1d")]
	public interface nsIFaviconService
	{
		
		/// <summary>
        /// Declares that a given page uses a favicon with the given URI.
        ///
        /// Will create an entry linking the favicon URI to the page, regardless
        /// the fact we have data for that icon.  You can populate it later with
        /// SetFaviconData.  However, remember that any favicons not associated with a
        /// visited web page, a bookmark, or a "place:" URI, will be removed during
        /// expiration runs.
        ///
        /// This will send out history pageChanged notification if the new favicon has
        /// any data and it's different from the old associated favicon.  This means
        /// that you should try to set data before calling this method if you have it,
        /// otherwise it won't fire any notifications.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon is being set.
        /// @param aFaviconURI
        /// URI of the favicon to associate with the page.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFaviconUrlForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// Same as SetFaviconUrlForPage except that this also attempts to fetch and
        /// save the icon data by loading the favicon URI through an async network
        /// request.
        ///
        /// If the icon data already exists, we won't normally try to re-load the
        /// icon.  If the icon is in the failed favicon cache we won't do anything.
        /// Use forceReload to force a reload of the data.  This will also eventually
        /// remove the favicon from the failed cache, if the reload succeeds.
        ///
        /// This function will only save favicons for "good" URIs, as defined by what
        /// gets added to history or is a bookmark.  For "bad" URIs, this function
        /// will succeed but do nothing.  This function will also ignore the error page
        /// favicon URI (see FAVICON_ERRORPAGE_URL below).
        /// Icons that fail to load will automatically be added to the failed favicon
        /// cache.
        ///
        /// This function will not save favicons for non-bookmarked URIs when
        /// history is disabled.  The rest of the functions
        /// here will always store favicons even when history is disabled.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon is being set.
        /// @param aFaviconURI
        /// URI of the favicon to associate with the page.
        /// @param aForceReload
        /// Unset is normal behavior, we will only try to reload the favicon
        /// if we don't have it or if it has expired from the cache.  If set,
        /// it will always try to reload the favicon.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAndLoadFaviconForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.Bool)] bool aForceReload, [MarshalAs(UnmanagedType.Interface)] nsIFaviconDataCallback aCallback);
		
		/// <summary>
        /// Stores the data for a given favicon URI.
        ///
        /// You can set the data even if you haven't called SetFaviconUrlForPage
        /// yet.  It will be stored but will not be associated with any page.
        /// However, any favicons not associated with a visited web page, bookmark,
        /// or "place:" URI will be expired when history expiration runs.  This might
        /// happen at any time, so you should not let the message loop run before
        /// you associate the icon or it may get deleted.
        ///
        /// It is best to set the favicon data, and then associate it with a page using
        /// setFaviconUrlForPage, otherwise it won't notify about the change.
        ///
        /// It's better to not use this function for chrome: icon URIs since you can
        /// reference the chrome image yourself. GetFaviconLinkForIcon/Page will ignore
        /// any associated data if the favicon URI is "chrome:" and just return the
        /// same chrome URI.
        ///
        /// This function does NOT send out notifications that the data has changed.
        /// Pages using this favicons that are visible in history or bookmarks views
        /// will keep the old icon until they have been refreshed by other means.
        ///
        /// This function tries to optimize the favicon size, if it is bigger
        /// than a defined limit we will try to convert it to a 16x16 png image.
        /// If the conversion fails and favicon is still bigger than our max accepted
        /// size it won't be saved.
        ///
        /// @param aFaviconURI
        /// URI of the favicon whose data is being set.
        /// @param aData
        /// Binary contents of the favicon to save
        /// @param aDataLength
        /// Length of binary data
        /// @param aMimeType
        /// MIME type of the data to store.  This is important so that we know
        /// what to report when the favicon is used.  You should always set this
        /// param unless you are clearing an icon.
        /// @param aExpiration
        /// Time in microseconds since the epoch when this favicon expires.
        /// Until this time, we won't try to load it again.
        /// @throws NS_ERROR_FAILURE
        /// Thrown if the favicon is overbloated and won't be saved to the db.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFaviconData([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, System.IntPtr aData, uint aDataLen, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType, uint aExpiration);
		
		/// <summary>
        /// Same as setFaviconData but the data is provided by a string
        /// containing a data URL.
        ///
        /// @see setFaviconData
        ///
        /// @param aFaviconURI
        /// URI of the favicon whose data is being set.
        /// @param aDataURL
        /// string containing a data URL that represents the contents of
        /// the favicon to save
        /// @param aExpiration
        /// Time in microseconds since the epoch when this favicon expires.
        /// Until this time, we won't try to load it again.
        /// @throws NS_ERROR_FAILURE
        /// Thrown if the favicon is overbloated and won't be saved to the db.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFaviconDataFromDataURL([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString aDataURL, uint aExpiration);
		
		/// <summary>
        /// Retrieves the given favicon data.  Throws if we don't have data.
        ///
        /// If there is no data but we have an entry for this favicon, aDataLen will
        /// be 0 and aData will be NULL.
        ///
        /// @param aFaviconURI
        /// URI of the favicon whose data is being read
        /// @param aData
        /// Output parameter where the binary favicon data will be placed.
        /// This will be null if we have this URI but have no data associated
        /// with it.
        /// @param aDataLen
        /// Output parameter where the size of the binary data will be placed.
        /// @param aMimeType
        /// Output parameter where the MIME type will be placed.
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// Thrown when we have never heard of this favicon URI.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetFaviconData([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType, out uint aDataLen);
		
		/// <summary>
        /// Same as getFaviconData, but returns data as a string containing a data url.
        ///
        /// @see getFaviconData
        ///
        /// @param aFaviconURI
        /// URI of the favicon whose data is being read
        /// @return A data URL containing the data of the favicon. This will be
        /// null if we have this URL but have no data associated with it.
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// Thrown when we have never heard of this favicon URL.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetFaviconDataAsDataURL([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// Retrieves the URI of the favicon for the given page.
        ///
        /// @param aPageURI
        /// URI of the page whose favicon is desired
        /// @return The URI of the favicon associated with that page. Returning a
        /// URI here does NOT mean that we have data for this favicon, only
        /// that we know what the favicon should be.
        /// @throws NS_ERROR_NOT_AVAILABLE
        /// When the page is not found or it has no favicon.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetFaviconForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI);
		
		/// <summary>
        /// Same as getFaviconLinkForIcon but this adds an extra level of indirection,
        /// looking up the favicon based on the page URI and using the default if not
        /// found.
        ///
        /// @see getFaviconLinkForIcon
        ///
        /// @param aPageURI
        /// URI of the page whose favicon is desired
        /// @return A URI that will give you the icon image.  This is NOT the URI of
        /// the icon as set on the page, but a URI that will give you the
        /// data out of the favicon service.  For a normal page with a
        /// favicon we've stored, this will be an annotation URI which will
        /// then cause the corresponding favicon data to be loaded async from
        /// this service.  For pages where we don't have a favicon, this will
        /// be a chrome URI of the default icon. For chrome URIs, the
        /// output will be the same as the input.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetFaviconImageForPage([MarshalAs(UnmanagedType.Interface)] nsIURI aPageURI);
		
		/// <summary>
        /// For a given icon URI, this will return a URI that will result in the image.
        /// In most cases, this is an annotation URI.  For chrome URIs, this will do
        /// nothing but returning the input URI.
        ///
        /// No validity checking is done. If you pass an icon URI that we've never
        /// seen, you'll get back a URI that references an invalid icon. The moz-anno
        /// protocol handler's special case for "favicon" annotations will resolve
        /// invalid icons to the default icon, although without caching.
        /// For invalid chrome URIs, you'll get a broken image.
        ///
        /// @param aFaviconURI
        /// The URI of an icon in the favicon service.
        /// @return A URI that will give you the icon image.  This is NOT the URI of
        /// the icon as set on the page, but a URI that will give you the
        /// data out of the favicon service.  For a normal page with a
        /// favicon we've stored, this will be an annotation URI which will
        /// then cause the corresponding favicon data to be loaded async from
        /// this service.  For pages where we don't have a favicon, this will
        /// be a chrome URI of the default icon. For chrome URIs, the
        /// output will be the same as the input.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetFaviconLinkForIcon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// Expire all known favicons from the database.
        ///
        /// @note This is an async method.
        /// On successful completion a "places-favicons-expired" notification is
        /// dispatched through observer's service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExpireAllFavicons();
		
		/// <summary>
        /// Adds a given favicon's URI to the failed favicon cache.
        ///
        /// The lifespan of the favicon cache is up to the caching system.  This cache
        /// will also be written when setAndLoadFaviconForPage hits an error while
        /// fetching an icon.
        ///
        /// @param aFaviconURI
        /// The URI of an icon in the favicon service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// Removes the given favicon from the failed favicon cache.  If the icon is
        /// not in the cache, it will silently succeed.
        ///
        /// @param aFaviconURI
        /// The URI of an icon in the favicon service.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// Checks to see if a favicon is in the failed favicon cache.
        /// A positive return value means the icon is in the failed cache and you
        /// probably shouldn't try to load it.  A false return value means that it's
        /// worth trying to load it.
        /// This allows you to avoid trying to load "foo.com/favicon.ico" for every
        /// page on a site that doesn't have a favicon.
        ///
        /// @param aFaviconURI
        /// The URI of an icon in the favicon service.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsFailedFavicon([MarshalAs(UnmanagedType.Interface)] nsIURI aFaviconURI);
		
		/// <summary>
        /// The default favicon URI
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetDefaultFaviconAttribute();
	}
	
	/// <summary>nsIFaviconDataCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("22ebd780-f4ab-11de-8a39-0800200c9a66")]
	public interface nsIFaviconDataCallback
	{
		
		/// <summary>
        /// Called when the required favicon's information is available.
        ///
        /// This callback will be called only if the operation is successful, otherwise
        /// you won't get notified.
        ///
        /// The caller will receive the most information we can gather on the icon,
        /// but it's not guaranteed that all of them will be set.  For some method
        /// we could not know the favicon's data (it could just be too expensive to
        /// get it, or the method does not require we actually have any data).
        /// It's up to the caller to check aDataLen > 0 before using any data-related
        /// information like mime-type or data itself.
        ///
        /// @param aURI
        /// Depending on caller method it could be:
        /// - a dataURI: has "data:" scheme, with base64 encoded icon data.
        /// - a faviconURI: the URI of the icon in the favicon service.
        /// - a faviconLinkURI: has "moz-anno" scheme, used to get data async.
        /// @param aDataLen
        /// Size of the icon data in bytes.  Notice that a value of 0 does not
        /// necessarily mean that we don't have an icon.
        /// @param aData
        /// Icon data, null if aDataLen is 0.
        /// @param aMimeType
        /// Mime type of the icon, null if aDataLen is 0.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnFaviconDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, uint aDataLen, System.IntPtr aData, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aMimeType);
	}
}
