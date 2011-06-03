// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIURI.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIURI.idl
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
	
	
	/// <summary>nsIURI </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("07a22cc0-0ce5-11d3-9331-00104ba0fd40")]
	public interface nsIURI
	{
		
		/// <summary>Member GetSpecAttribute </summary>
		/// <param name='aSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aSpec);
		
		/// <summary>Member SetSpecAttribute </summary>
		/// <param name='aSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aSpec);
		
		/// <summary>Member GetPrePathAttribute </summary>
		/// <param name='aPrePath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPrePath);
		
		/// <summary>Member GetSchemeAttribute </summary>
		/// <param name='aScheme'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aScheme);
		
		/// <summary>Member SetSchemeAttribute </summary>
		/// <param name='aScheme'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSchemeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aScheme);
		
		/// <summary>Member GetUserPassAttribute </summary>
		/// <param name='aUserPass'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aUserPass);
		
		/// <summary>Member SetUserPassAttribute </summary>
		/// <param name='aUserPass'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUserPassAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aUserPass);
		
		/// <summary>Member GetUsernameAttribute </summary>
		/// <param name='aUsername'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aUsername);
		
		/// <summary>Member SetUsernameAttribute </summary>
		/// <param name='aUsername'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsernameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aUsername);
		
		/// <summary>Member GetPasswordAttribute </summary>
		/// <param name='aPassword'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPassword);
		
		/// <summary>Member SetPasswordAttribute </summary>
		/// <param name='aPassword'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPasswordAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPassword);
		
		/// <summary>Member GetHostPortAttribute </summary>
		/// <param name='aHostPort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHostPort);
		
		/// <summary>Member SetHostPortAttribute </summary>
		/// <param name='aHostPort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostPortAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHostPort);
		
		/// <summary>Member GetHostAttribute </summary>
		/// <param name='aHost'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHost);
		
		/// <summary>Member SetHostAttribute </summary>
		/// <param name='aHost'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aHost);
		
		/// <summary>Member GetPortAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetPortAttribute();
		
		/// <summary>Member SetPortAttribute </summary>
		/// <param name='aPort'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPortAttribute(System.Int32  aPort);
		
		/// <summary>Member GetPathAttribute </summary>
		/// <param name='aPath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPath);
		
		/// <summary>Member SetPathAttribute </summary>
		/// <param name='aPath'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPath);
		
		/// <summary>Member Equals </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIURI  other);
		
		/// <summary>Member SchemeIs </summary>
		/// <param name='scheme'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SchemeIs([MarshalAs(UnmanagedType.LPStr)] System.String  scheme);
		
		/// <summary>Member Clone </summary>
		/// <returns>A nsIURI</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI Clone();
		
		/// <summary>Member Resolve </summary>
		/// <param name='relativePath'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAString  relativePath);
		
		/// <summary>Member GetAsciiSpecAttribute </summary>
		/// <param name='aAsciiSpec'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsciiSpecAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aAsciiSpec);
		
		/// <summary>Member GetAsciiHostAttribute </summary>
		/// <param name='aAsciiHost'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsciiHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aAsciiHost);
		
		/// <summary>Member GetOriginCharsetAttribute </summary>
		/// <param name='aOriginCharset'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginCharsetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aOriginCharset);
	}
}