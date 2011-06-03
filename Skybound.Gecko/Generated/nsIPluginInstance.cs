// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPluginInstance.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPluginInstance.idl
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
	
	
	/// <summary>nsIPluginInstance </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("84994340-E120-4051-824F-D4EE8AEF1A3E")]
	public interface nsIPluginInstance
	{
		
		/// <summary>Member Initialize </summary>
		/// <param name='aOwner'> </param>
		/// <param name='aMIMEType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Initialize([MarshalAs(UnmanagedType.Interface)] nsIPluginInstanceOwner  aOwner, [MarshalAs(UnmanagedType.LPStr)] System.String  aMIMEType);
		
		/// <summary>Member Start </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Start();
		
		/// <summary>Member Stop </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop();
		
		/// <summary>Member SetWindow </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindow(System.IntPtr aWindow);
		
		/// <summary>Member NewStreamToPlugin </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NewStreamToPlugin([MarshalAs(UnmanagedType.Interface)] out nsIPluginStreamListener  aListener);
		
		/// <summary>Member NewStreamFromPlugin </summary>
		/// <param name='aType'> </param>
		/// <param name='aTarget'> </param>
		/// <param name='aResult'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NewStreamFromPlugin([MarshalAs(UnmanagedType.LPStr)] System.String  aType, [MarshalAs(UnmanagedType.LPStr)] System.String  aTarget, [MarshalAs(UnmanagedType.Interface)] out nsIOutputStream  aResult);
		
		/// <summary>Member Print </summary>
		/// <param name='aPlatformPrint'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Print(System.IntPtr aPlatformPrint);
		
		/// <summary>Member HandleEvent </summary>
		/// <param name='aEvent'> </param>
		/// <param name='aHandled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent(System.IntPtr  aEvent, out System.Int16  aHandled);
		
		/// <summary>Member InvalidateRect </summary>
		/// <param name='aRect'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvalidateRect(System.IntPtr aRect);
		
		/// <summary>Member InvalidateRegion </summary>
		/// <param name='aRegion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvalidateRegion(System.IntPtr aRegion);
		
		/// <summary>Member ForceRedraw </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ForceRedraw();
		
		/// <summary>Member GetMIMEType </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMIMEType([MarshalAs(UnmanagedType.LPStr)] out System.String  aValue);
		
		/// <summary>Member GetJSContextAttribute </summary>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  GetJSContextAttribute();
		
		/// <summary>Member GetOwnerAttribute </summary>
		/// <returns>A nsIPluginInstanceOwner </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPluginInstanceOwner  GetOwnerAttribute();
		
		/// <summary>Member SetOwnerAttribute </summary>
		/// <param name='aOwner'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsIPluginInstanceOwner  aOwner);
		
		/// <summary>Member ShowStatus </summary>
		/// <param name='aMessage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowStatus([MarshalAs(UnmanagedType.LPStr)] System.String  aMessage);
		
		/// <summary>Member InvalidateOwner </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvalidateOwner();
		
		/// <summary>Member GetJSObject </summary>
		/// <param name='cx'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetJSObject(System.IntPtr  cx);
		
		/// <summary>Member GetFormValueAttribute </summary>
		/// <param name='aFormValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFormValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFormValue);
		
		/// <summary>Member PushPopupsEnabledState </summary>
		/// <param name='aEnabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PushPopupsEnabledState(System.Boolean  aEnabled);
		
		/// <summary>Member PopPopupsEnabledState </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PopPopupsEnabledState();
		
		/// <summary>Member GetPluginAPIVersionAttribute </summary>
		/// <returns>A System.UInt16 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt16  GetPluginAPIVersionAttribute();
		
		/// <summary>Member DefineJavaProperties </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DefineJavaProperties();
		
		/// <summary>Member ShouldCache </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ShouldCache();
		
		/// <summary>Member IsWindowless </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsWindowless();
		
		/// <summary>Member IsTransparent </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsTransparent();
		
		/// <summary>Member GetValueFromPlugin </summary>
		/// <param name='variable'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueFromPlugin(System.IntPtr variable, System.IntPtr  aValue);
		
		/// <summary>Member GetDrawingModel </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDrawingModel();
		
		/// <summary>Member AsyncSetWindow </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncSetWindow(System.IntPtr aWindow);
		
		/// <summary>Member NotifyPainted </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NotifyPainted();
		
		/// <summary>Member GetSurface </summary>
		/// <param name='aSurface'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSurface(out System.IntPtr aSurface);
		
		/// <summary>Member UseAsyncPainting </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool UseAsyncPainting();
	}
	
	/// <summary>nsIPluginInstance_MOZILLA_2_0_BRANCH </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("24235105-ac5f-483b-86ec-7c9446ddcb8a")]
	public interface nsIPluginInstance_MOZILLA_2_0_BRANCH : nsIPluginInstance
	{
		
		/// <summary>Member Initialize </summary>
		/// <param name='aOwner'> </param>
		/// <param name='aMIMEType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Initialize([MarshalAs(UnmanagedType.Interface)] nsIPluginInstanceOwner  aOwner, [MarshalAs(UnmanagedType.LPStr)] System.String  aMIMEType);
		
		/// <summary>Member Start </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Start();
		
		/// <summary>Member Stop </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Stop();
		
		/// <summary>Member SetWindow </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetWindow(System.IntPtr aWindow);
		
		/// <summary>Member NewStreamToPlugin </summary>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void NewStreamToPlugin([MarshalAs(UnmanagedType.Interface)] out nsIPluginStreamListener  aListener);
		
		/// <summary>Member NewStreamFromPlugin </summary>
		/// <param name='aType'> </param>
		/// <param name='aTarget'> </param>
		/// <param name='aResult'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void NewStreamFromPlugin([MarshalAs(UnmanagedType.LPStr)] System.String  aType, [MarshalAs(UnmanagedType.LPStr)] System.String  aTarget, [MarshalAs(UnmanagedType.Interface)] out nsIOutputStream  aResult);
		
		/// <summary>Member Print </summary>
		/// <param name='aPlatformPrint'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Print(System.IntPtr aPlatformPrint);
		
		/// <summary>Member HandleEvent </summary>
		/// <param name='aEvent'> </param>
		/// <param name='aHandled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void HandleEvent(System.IntPtr  aEvent, out System.Int16  aHandled);
		
		/// <summary>Member InvalidateRect </summary>
		/// <param name='aRect'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InvalidateRect(System.IntPtr aRect);
		
		/// <summary>Member InvalidateRegion </summary>
		/// <param name='aRegion'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InvalidateRegion(System.IntPtr aRegion);
		
		/// <summary>Member ForceRedraw </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ForceRedraw();
		
		/// <summary>Member GetMIMEType </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMIMEType([MarshalAs(UnmanagedType.LPStr)] out System.String  aValue);
		
		/// <summary>Member GetJSContextAttribute </summary>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr  GetJSContextAttribute();
		
		/// <summary>Member GetOwnerAttribute </summary>
		/// <returns>A nsIPluginInstanceOwner </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIPluginInstanceOwner  GetOwnerAttribute();
		
		/// <summary>Member SetOwnerAttribute </summary>
		/// <param name='aOwner'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsIPluginInstanceOwner  aOwner);
		
		/// <summary>Member ShowStatus </summary>
		/// <param name='aMessage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ShowStatus([MarshalAs(UnmanagedType.LPStr)] System.String  aMessage);
		
		/// <summary>Member InvalidateOwner </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InvalidateOwner();
		
		/// <summary>Member GetJSObject </summary>
		/// <param name='cx'> </param>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetJSObject(System.IntPtr  cx);
		
		/// <summary>Member GetFormValueAttribute </summary>
		/// <param name='aFormValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetFormValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFormValue);
		
		/// <summary>Member PushPopupsEnabledState </summary>
		/// <param name='aEnabled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PushPopupsEnabledState(System.Boolean  aEnabled);
		
		/// <summary>Member PopPopupsEnabledState </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PopPopupsEnabledState();
		
		/// <summary>Member GetPluginAPIVersionAttribute </summary>
		/// <returns>A System.UInt16 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt16  GetPluginAPIVersionAttribute();
		
		/// <summary>Member DefineJavaProperties </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void DefineJavaProperties();
		
		/// <summary>Member ShouldCache </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool ShouldCache();
		
		/// <summary>Member IsWindowless </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsWindowless();
		
		/// <summary>Member IsTransparent </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsTransparent();
		
		/// <summary>Member GetValueFromPlugin </summary>
		/// <param name='variable'> </param>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetValueFromPlugin(System.IntPtr variable, System.IntPtr  aValue);
		
		/// <summary>Member GetDrawingModel </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetDrawingModel();
		
		/// <summary>Member AsyncSetWindow </summary>
		/// <param name='aWindow'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AsyncSetWindow(System.IntPtr aWindow);
		
		/// <summary>Member NotifyPainted </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void NotifyPainted();
		
		/// <summary>Member GetSurface </summary>
		/// <param name='aSurface'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSurface(out System.IntPtr aSurface);
		
		/// <summary>Member UseAsyncPainting </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool UseAsyncPainting();
		
		/// <summary>Member IsRemoteDrawingCoreAnimation </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsRemoteDrawingCoreAnimation();
		
		/// <summary>Member GetImage </summary>
		/// <param name='aContainer'> </param>
		/// <param name='aImage'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImage(System.IntPtr  aContainer, out System.IntPtr  aImage);
		
		/// <summary>Member GetImageSize </summary>
		/// <param name='aSize'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetImageSize(System.IntPtr aSize);
		
		/// <summary>Member SetBackgroundUnknown </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBackgroundUnknown();
		
		/// <summary>Member BeginUpdateBackground </summary>
		/// <param name='rect'> </param>
		/// <param name='ctx'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginUpdateBackground(System.IntPtr rect, out System.IntPtr ctx);
		
		/// <summary>Member EndUpdateBackground </summary>
		/// <param name='ctx'> </param>
		/// <param name='rect'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndUpdateBackground(System.IntPtr ctx, System.IntPtr rect);
	}
}