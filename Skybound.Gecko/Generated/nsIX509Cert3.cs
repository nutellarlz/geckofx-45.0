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
// Generated by IDLImporter from file nsIX509Cert3.idl
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
    /// Extending nsIX509Cert
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("399004d8-b8c7-4eb9-8362-d99f4c0161fd")]
	public interface nsIX509Cert3 : nsIX509Cert2
	{
		
		/// <summary>
        /// A nickname for the certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNicknameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNickname);
		
		/// <summary>
        /// The primary email address of the certificate, if present.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetEmailAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEmailAddress);
		
		/// <summary>
        /// Obtain a list of all email addresses
        /// contained in the certificate.
        ///
        /// @param length The number of strings in the returned array.
        /// @return An array of email addresses.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetEmailAddresses(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] addresses);
		
		/// <summary>
        /// Check whether a given address is contained in the certificate.
        /// The comparison will convert the email address to lowercase.
        /// The behaviour for non ASCII characters is undefined.
        ///
        /// @param aEmailAddress The address to search for.
        ///
        /// @return True if the address is contained in the certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool ContainsEmailAddress([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aEmailAddress);
		
		/// <summary>
        /// The subject owning the certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSubjectNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSubjectName);
		
		/// <summary>
        /// The subject's common name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCommonNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCommonName);
		
		/// <summary>
        /// The subject's organization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetOrganizationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aOrganization);
		
		/// <summary>
        /// The subject's organizational unit.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetOrganizationalUnitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aOrganizationalUnit);
		
		/// <summary>
        /// The fingerprint of the certificate's public key,
        /// calculated using the SHA1 algorithm.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSha1FingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSha1Fingerprint);
		
		/// <summary>
        /// The fingerprint of the certificate's public key,
        /// calculated using the MD5 algorithm.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMd5FingerprintAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMd5Fingerprint);
		
		/// <summary>
        /// A human readable name identifying the hardware or
        /// software token the certificate is stored on.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTokenNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTokenName);
		
		/// <summary>
        /// The subject identifying the issuer certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIssuerNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIssuerName);
		
		/// <summary>
        /// The serial number the issuer assigned to this certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSerialNumberAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSerialNumber);
		
		/// <summary>
        /// The issuer subject's common name.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIssuerCommonNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIssuerCommonName);
		
		/// <summary>
        /// The issuer subject's organization.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIssuerOrganizationAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIssuerOrganization);
		
		/// <summary>
        /// The issuer subject's organizational unit.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetIssuerOrganizationUnitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aIssuerOrganizationUnit);
		
		/// <summary>
        /// The certificate used by the issuer to sign this certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIX509Cert GetIssuerAttribute();
		
		/// <summary>
        /// This certificate's validity period.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIX509CertValidity GetValidityAttribute();
		
		/// <summary>
        /// A unique identifier of this certificate within the local storage.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetDbKeyAttribute();
		
		/// <summary>
        /// A human readable identifier to label this certificate.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetWindowTitleAttribute();
		
		/// <summary>
        /// Obtain a list of certificates that contains this certificate
        /// and the issuing certificates of all involved issuers,
        /// up to the root issuer.
        ///
        /// @return The chain of certifficates including the issuers.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIArray GetChain();
		
		/// <summary>
        /// Obtain an array of human readable strings describing
        /// the certificate's certified usages.
        ///
        /// @param localOnly Do not hit the network, even if revocation information
        /// downloading is currently activated.
        /// @param verified The certificate verification result, see constants.
        /// @param count The number of human readable usages returned.
        /// @param usages The array of human readable usages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUsagesArray([MarshalAs(UnmanagedType.U1)] bool localOnly, ref uint verified, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=2)] ref System.IntPtr[] usages);
		
		/// <summary>
        /// Obtain a single comma separated human readable string describing
        /// the certificate's certified usages.
        ///
        /// @param localOnly Do not hit the network, even if revocation information
        /// downloading is currently activated.
        /// @param verified The certificate verification result, see constants.
        /// @param purposes The string listing the usages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetUsagesString([MarshalAs(UnmanagedType.U1)] bool localOnly, ref uint verified, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase usages);
		
		/// <summary>
        /// Verify the certificate for a particular usage.
        ///
        /// @return The certificate verification result, see constants.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint VerifyForUsage(uint usage);
		
		/// <summary>
        /// This is the attribute which describes the ASN1 layout
        /// of the certificate.  This can be used when doing a
        /// "pretty print" of the certificate's ASN1 structure.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIASN1Object GetASN1StructureAttribute();
		
		/// <summary>
        /// Obtain a raw binary encoding of this certificate
        /// in DER format.
        ///
        /// @param length The number of bytes in the binary encoding.
        /// @param data The bytes representing the DER encoded certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetRawDER(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref byte[] data);
		
		/// <summary>
        /// Test whether two certificate instances represent the
        /// same certificate.
        ///
        /// @return Whether the certificates are equal
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)] nsIX509Cert other);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetCertTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MarkForPermDeletion();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetCert();
		
		/// <summary>
        /// Async version of nsIX509Cert::getUsagesArray()
        ///
        /// Will not block, will request results asynchronously,
        /// availability of results will be notified on the main thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RequestUsagesArrayAsync([MarshalAs(UnmanagedType.Interface)] nsICertVerificationListener cvl);
		
		/// <summary>
        /// Obtain the certificate wrapped in a PKCS#7 SignedData structure,
        /// with or without the certificate chain
        ///
        /// @param chainMode Whether to include the chain (with or without the root),
        ///                       see CMS_CHAIN_MODE constants.
        /// @param length The number of bytes of the PKCS#7 data.
        /// @param data The bytes representing the PKCS#7 wrapped certificate.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExportAsCMS(uint chainMode, ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref byte[] data);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsSelfSignedAttribute();
		
		/// <summary>
        /// Human readable names identifying all hardware or
        /// software tokens the certificate is stored on.
        ///
        /// @param length On success, the number of entries in the returned array.
        /// @return On success, an array containing the names of all tokens
        /// the certificate is stored on (may be empty).
        /// On failure the function throws/returns an error.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAllTokenNames(ref uint length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref System.IntPtr[] tokenNames);
	}
	
	/// <summary>nsIX509Cert3Consts </summary>
	public class nsIX509Cert3Consts
	{
		
		// <summary>
        // Constants for specifying the chain mode when exporting a certificate
        // </summary>
		public const ulong CMS_CHAIN_MODE_CertOnly = 1;
		
		// 
		public const ulong CMS_CHAIN_MODE_CertChain = 2;
		
		// 
		public const ulong CMS_CHAIN_MODE_CertChainWithRoot = 3;
	}
	
	/// <summary>nsICertVerificationResult </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2fd0a785-9f2d-4327-8871-8c3e0783891d")]
	public interface nsICertVerificationResult
	{
		
		/// <summary>
        /// This interface reflects a container of
        /// verification results. Call will not block.
        ///
        /// Obtain an array of human readable strings describing
        /// the certificate's certified usages.
        ///
        /// Mirrors the results produced by
        /// nsIX509Cert::getUsagesArray()
        ///
        /// As of today, this function is a one-shot object,
        /// only the first call will succeed.
        /// This allows an optimization in the implementation,
        /// ownership of result data will be transfered to caller.
        ///
        /// @param cert The certificate that was verified.
        /// @param verified The certificate verification result,
        /// see constants in nsIX509Cert.
        /// @param count The number of human readable usages returned.
        /// @param usages The array of human readable usages.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsagesArrayResult(ref uint verified, ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] ref System.IntPtr[] usages);
	}
	
	/// <summary>nsICertVerificationListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6684bce9-50db-48e1-81b7-98102bf81357")]
	public interface nsICertVerificationListener
	{
		
		/// <summary>
        /// Notify that results are ready, that have been requested
        /// using nsIX509Cert3::requestUsagesArrayAsync()
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Notify([MarshalAs(UnmanagedType.Interface)] nsIX509Cert3 verifiedCert, [MarshalAs(UnmanagedType.Interface)] nsICertVerificationResult result);
	}
}
