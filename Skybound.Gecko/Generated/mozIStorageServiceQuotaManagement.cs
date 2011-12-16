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
// Generated by IDLImporter from file mozIStorageServiceQuotaManagement.idl
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
	
	
	/// <summary>mozIStorageQuotaCallback </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ae94f0a5-ebdf-48f4-9959-085e13235d8d")]
	public interface mozIStorageQuotaCallback
	{
		
		/// <summary>
        /// Called when the file size quota for a group of databases is exceeded.
        ///
        /// @param aFilename
        /// The filename of the database that has exceeded the quota.
        ///
        /// @param aCurrentSizeLimit
        /// The current size (in bytes) of the quota.
        ///
        /// @param aCurrentTotalSize
        /// The current size of all databases in the quota group.
        ///
        /// @param aUserData
        /// Any additional data that was provided to the
        /// setQuotaForFilenamePattern function.
        ///
        /// @returns A new quota size. A new quota of 0 will disable the quota callback
        /// and any quota value less than aCurrentTotalSize will cause the
        /// database operation to fail with NS_ERROR_FILE_NO_DEVICE_SPACE.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int QuotaExceeded([MarshalAs(UnmanagedType.LPStruct)] nsACString aFilename, int aCurrentSizeLimit, int aCurrentTotalSize, [MarshalAs(UnmanagedType.Interface)] nsISupports aUserData);
	}
	
	/// <summary>
    /// This is a temporary interface that should eventually merge with
    /// mozIStorageService.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("11def472-446f-4635-a1d8-8856e85aac50")]
	public interface mozIStorageServiceQuotaManagement
	{
		
		/// <summary>
        /// See mozIStorageService.openDatabase. Exactly the same only with a custom
        /// SQLite VFS.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		mozIStorageConnection OpenDatabaseWithVFS([MarshalAs(UnmanagedType.Interface)] nsIFile aDatabaseFile, [MarshalAs(UnmanagedType.LPStruct)] nsACString aVFSName);
		
		/// <summary>
        /// Set a file size quota for a group of databases matching the given filename
        /// pattern, optionally specifying a callback when the quota is exceeded.
        ///
        /// @param aPattern
        /// A pattern to match filenames for inclusion in the quota system. May
        /// contain the following special characters:
        /// '*'    Matches any sequence of zero or more characters.
        /// '?'    Matches exactly one character.
        /// [...]  Matches one character from the enclosed list of characters.
        /// [^...] Matches one character not in the enclosed list.
        ///
        /// @param aSizeLimit
        /// The size limit (in bytes) for the quota group.
        ///
        /// @param aCallback
        /// A callback that will be used when the quota is exceeded.
        ///
        /// @param aUserData
        /// Additional information to be passed to the callback.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetQuotaForFilenamePattern([MarshalAs(UnmanagedType.LPStruct)] nsACString aPattern, int aSizeLimit, mozIStorageQuotaCallback aCallback, [MarshalAs(UnmanagedType.Interface)] nsISupports aUserData);
		
		/// <summary>
        /// Adds, removes, or updates the file size information maintained by the quota
        /// system for files not opened through openDatabaseWithVFS().
        ///
        /// Use this function when you want files to be included in quota calculations
        /// that are either a) not SQLite databases, or b) SQLite databases that have
        /// not been opened.
        ///
        /// This function will have no effect on files that do not match an existing
        /// quota pattern (set previously by setQuotaForFilenamePattern()).
        ///
        /// @param aFile
        /// The file for which quota information should be updated. If the file
        /// exists then its size information will be added or refreshed. If the
        /// file does not exist then the file will be removed from tracking
        /// under the quota system.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateQutoaInformationForFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
	}
}
