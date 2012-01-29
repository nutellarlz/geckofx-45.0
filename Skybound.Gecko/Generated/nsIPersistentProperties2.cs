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
// Generated by IDLImporter from file nsIPersistentProperties2.idl
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
	
	
	/// <summary>nsIPropertyElement </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("283EE646-1AEF-11D4-98B3-00C04fA0CE9A")]
	public interface nsIPropertyElement
	{
		
		/// <summary>Member GetKeyAttribute </summary>
		/// <param name='aKey'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aKey);
		
		/// <summary>Member SetKeyAttribute </summary>
		/// <param name='aKey'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aKey);
		
		/// <summary>Member GetValueAttribute </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
		
		/// <summary>Member SetValueAttribute </summary>
		/// <param name='aValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);
	}
	
	/// <summary>nsIPersistentProperties </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1A180F60-93B2-11d2-9B8B-00805F8A16D9")]
	public interface nsIPersistentProperties : nsIProperties
	{
		
		/// <summary>
        /// Gets a property with a given name.
        ///
        /// @return NS_ERROR_FAILURE if a property with that name doesn't exist.
        /// @return NS_ERROR_NO_INTERFACE if the found property fails to QI to the
        /// given iid.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr Get([MarshalAs(UnmanagedType.LPStr)] string prop, ref System.Guid iid);
		
		/// <summary>
        /// Sets a property with a given name to a given value.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Set([MarshalAs(UnmanagedType.LPStr)] string prop, [MarshalAs(UnmanagedType.Interface)] nsISupports value);
		
		/// <summary>
        /// Returns true if the property with the given name exists.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Has([MarshalAs(UnmanagedType.LPStr)] string prop);
		
		/// <summary>
        /// Undefines a property.
        /// @return NS_ERROR_FAILURE if a property with that name doesn't
        /// already exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Undefine([MarshalAs(UnmanagedType.LPStr)] string prop);
		
		/// <summary>
        /// Returns an array of the keys.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetKeys(ref uint count, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] ref string[] keys);
		
		/// <summary>
        /// load a set of name/value pairs from the input stream
        /// names and values should be in UTF8
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Load([MarshalAs(UnmanagedType.Interface)] nsIInputStream input);
		
		/// <summary>
        /// output the values to the stream - results will be in UTF8
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Save([MarshalAs(UnmanagedType.Interface)] nsIOutputStream output, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String header);
		
		/// <summary>
        /// call subclass() to make future calls to load() set the properties
        /// in this "superclass" instead
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Subclass([MarshalAs(UnmanagedType.Interface)] nsIPersistentProperties superclass);
		
		/// <summary>
        /// get an enumeration of nsIPropertyElement objects,
        /// which are read-only (i.e. setting properties on the element will
        /// not make changes back into the source nsIPersistentProperties
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator Enumerate();
		
		/// <summary>
        /// shortcut to nsIProperty's get() which retrieves a string value
        /// directly (and thus faster)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStringProperty([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String key, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
		
		/// <summary>
        /// shortcut to nsIProperty's set() which sets a string value
        /// directly (and thus faster). If the given property already exists,
        /// then the old value will be returned
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStringProperty([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String key, [MarshalAs(UnmanagedType.LPStruct)] nsAString value, [MarshalAs(UnmanagedType.LPStruct)] nsAString retval);
	}
}
