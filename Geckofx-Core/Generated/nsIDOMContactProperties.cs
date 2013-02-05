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
// Generated by IDLImporter from file nsIDOMContactProperties.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("eba48030-89e8-11e1-b0c4-0800200c9a66")]
	public interface nsIDOMContactAddress
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
        /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
        /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStreetAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aStreetAddress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStreetAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aStreetAddress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLocalityAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLocality);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLocalityAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLocality);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRegionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aRegion);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRegionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aRegion);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPostalCodeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPostalCode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPostalCodeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPostalCode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCountryNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCountryName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCountryNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCountryName);
	}
	
	/// <summary>nsIDOMContactField </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e2cb19c0-e4aa-11e1-9b23-0800200c9a66")]
	public interface nsIDOMContactField
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetTypeAttribute();
		
		/// <summary>Member SetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTypeAttribute(Gecko.JsVal aType);
		
		/// <summary>
        /// DOMString[] for primary/favorite (use:"PREF"), "home", "work", etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>
        /// DOMString[] for primary/favorite (use:"PREF"), "home", "work", etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
	}
	
	/// <summary>nsIDOMContactTelField </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ed0ab260-e4aa-11e1-9b23-0800200c9a66")]
	public interface nsIDOMContactTelField : nsIDOMContactField
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new Gecko.JsVal GetTypeAttribute();
		
		/// <summary>Member SetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTypeAttribute(Gecko.JsVal aType);
		
		/// <summary>
        /// DOMString[] for primary/favorite (use:"PREF"), "home", "work", etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>
        /// DOMString[] for primary/favorite (use:"PREF"), "home", "work", etc.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aValue);
		
		/// <summary>Member GetCarrierAttribute </summary>
		/// <param name='aCarrier'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCarrierAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCarrier);
		
		/// <summary>Member SetCarrierAttribute </summary>
		/// <param name='aCarrier'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCarrierAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCarrier);
	}
	
	/// <summary>nsIDOMContactFindOptions </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e31daea0-0cb6-11e1-be50-0800200c9a66")]
	public interface nsIDOMContactFindOptions
	{
		
		/// <summary>Member GetFilterValueAttribute </summary>
		/// <param name='aFilterValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFilterValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFilterValue);
		
		/// <summary>Member SetFilterValueAttribute </summary>
		/// <param name='aFilterValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilterValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFilterValue);
		
		/// <summary>
        /// e.g. "Tom"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFilterOpAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFilterOp);
		
		/// <summary>
        /// e.g. "Tom"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilterOpAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aFilterOp);
		
		/// <summary>
        /// e.g. "contains"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetFilterByAttribute();
		
		/// <summary>
        /// e.g. "contains"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilterByAttribute(Gecko.JsVal aFilterBy);
		
		/// <summary>
        /// DOMString[], e.g. ["givenName", "nickname"]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSortByAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSortBy);
		
		/// <summary>
        /// DOMString[], e.g. ["givenName", "nickname"]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSortByAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSortBy);
		
		/// <summary>
        /// "givenName" or "familyName"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSortOrderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSortOrder);
		
		/// <summary>
        /// "givenName" or "familyName"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSortOrderAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSortOrder);
		
		/// <summary>
        /// e.g. "descending"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFilterLimitAttribute();
		
		/// <summary>
        /// e.g. "descending"
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFilterLimitAttribute(uint aFilterLimit);
	}
	
	/// <summary>nsIDOMContactProperties </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f0ddb360-e4aa-11e1-9b23-0800200c9a66")]
	public interface nsIDOMContactProperties
	{
		
		/// <summary>Member GetNameAttribute </summary>
		/// <returns>A Gecko.JsVal</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetNameAttribute();
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute(Gecko.JsVal aName);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetHonorificPrefixAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHonorificPrefixAttribute(Gecko.JsVal aHonorificPrefix);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetGivenNameAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGivenNameAttribute(Gecko.JsVal aGivenName);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetAdditionalNameAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAdditionalNameAttribute(Gecko.JsVal aAdditionalName);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetFamilyNameAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFamilyNameAttribute(Gecko.JsVal aFamilyName);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetHonorificSuffixAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHonorificSuffixAttribute(Gecko.JsVal aHonorificSuffix);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetNicknameAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNicknameAttribute(Gecko.JsVal aNickname);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetEmailAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEmailAttribute(Gecko.JsVal aEmail);
		
		/// <summary>
        /// ContactField[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetPhotoAttribute();
		
		/// <summary>
        /// ContactField[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPhotoAttribute(Gecko.JsVal aPhoto);
		
		/// <summary>
        /// nsIDOMBlob[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetUrlAttribute();
		
		/// <summary>
        /// nsIDOMBlob[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUrlAttribute(Gecko.JsVal aUrl);
		
		/// <summary>
        /// ContactField[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetCategoryAttribute();
		
		/// <summary>
        /// ContactField[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCategoryAttribute(Gecko.JsVal aCategory);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetAdrAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAdrAttribute(Gecko.JsVal aAdr);
		
		/// <summary>
        /// ContactAddress[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetTelAttribute();
		
		/// <summary>
        /// ContactAddress[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTelAttribute(Gecko.JsVal aTel);
		
		/// <summary>
        /// ContactTelField[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOrgAttribute();
		
		/// <summary>
        /// ContactTelField[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOrgAttribute(Gecko.JsVal aOrg);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetJobTitleAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetJobTitleAttribute(Gecko.JsVal aJobTitle);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetBdayAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBdayAttribute(Gecko.JsVal aBday);
		
		/// <summary>
        /// Date
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetNoteAttribute();
		
		/// <summary>
        /// Date
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNoteAttribute(Gecko.JsVal aNote);
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetImppAttribute();
		
		/// <summary>
        /// DOMString[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetImppAttribute(Gecko.JsVal aImpp);
		
		/// <summary>
        /// ContactField[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetAnniversaryAttribute();
		
		/// <summary>
        /// ContactField[]
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAnniversaryAttribute(Gecko.JsVal aAnniversary);
		
		/// <summary>
        /// Date
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetSexAttribute();
		
		/// <summary>
        /// Date
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSexAttribute(Gecko.JsVal aSex);
		
		/// <summary>
        /// DOMString
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetGenderIdentityAttribute();
		
		/// <summary>
        /// DOMString
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetGenderIdentityAttribute(Gecko.JsVal aGenderIdentity);
	}
}
