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
// Generated by IDLImporter from file nsISAXAttributes.idl
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
    /// Interface for a list of XML attributes.
    ///
    /// This interface allows access to a list of attributes in
    /// three different ways:
    ///
    /// 1.) by attribute index;
    /// 2.) by Namespace-qualified name; or
    /// 3.) by XML qualified name.
    ///
    /// The list will not contain attributes that were declared #IMPLIED
    /// but not specified in the start tag.  It will also not contain
    /// attributes used as Namespace declarations (xmlns*) unless the
    /// http://xml.org/sax/features/namespace-prefixes feature
    /// is set to true (it is false by default).
    ///
    /// The order of attributes in the list is unspecified.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e347005e-6cd0-11da-be43-001422106990")]
	public interface nsISAXAttributes
	{
		
		/// <summary>
        /// Look up the index of an attribute by Namespace name.
        /// @param uri The Namespace URI, or the empty string
        /// if the name has no Namespace URI.
        /// @param localName The attribute's local name.
        /// @return The index of the attribute, or -1
        /// if it does not appear in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIndexFromName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		/// <summary>
        /// Look up the index of an attribute by XML qualified name.
        /// @param qName The qualified name.
        /// @return The index of the attribute, or -1
        /// if it does not appear in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIndexFromQName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase qName);
		
		/// <summary>
        /// Return the number of attributes in the list. Once you know the
        /// number of attributes, you can iterate through the list.
        ///
        /// @return The number of attributes in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLengthAttribute();
		
		/// <summary>
        /// Look up an attribute's local name by index.
        /// @param index The attribute index (zero-based).
        /// @return The local name, or null if the index is out of range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLocalName(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Look up an attribute's XML qualified name by index.
        /// @param index The attribute index (zero-based).
        /// @return The XML qualified name, or the empty string if none is
        /// available, or null if the index is out of range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetQName(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Look up an attribute's type by index. The attribute type is one
        /// of the strings "CDATA", "ID", "IDREF", "IDREFS", "NMTOKEN",
        /// "NMTOKENS", "ENTITY", "ENTITIES", or "NOTATION" (always in upper
        /// case). If the parser has not read a declaration for the
        /// attribute, or if the parser does not report attribute types, then
        /// it must return the value "CDATA" as stated in the XML 1.0
        /// Recommendation (clause 3.3.3, "Attribute-Value
        /// Normalization"). For an enumerated attribute that is not a
        /// notation, the parser will report the type as "NMTOKEN".
        ///
        /// @param index The attribute index (zero-based).
        /// @return The attribute's type as a string, or null if the index is
        /// out of range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetType(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Look up an attribute's type by Namespace name.
        /// @param uri The Namespace URI, or the empty string
        /// if the name has no Namespace URI.
        /// @param localName The attribute's local name.
        /// @return The attribute type as a string, or null if the attribute
        /// is not in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeFromName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Look up an attribute's type by XML qualified name.
        /// @param qName The qualified name.
        /// @return The attribute type as a string, or null if the attribute
        /// is not in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeFromQName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase qName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Look up an attribute's Namespace URI by index.
        /// @param index The attribute index (zero-based).
        /// @return The Namespace URI, or the empty string if none is available,
        /// or null if the index is out of range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURI(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Look up an attribute's value by index.  If the attribute value is
        /// a list of tokens (IDREFS, ENTITIES, or NMTOKENS), the tokens will
        /// be concatenated into a single string with each token separated by
        /// a single space.
        ///
        /// @param index The attribute index (zero-based).
        /// @return The attribute's value as a string, or null if the index is
        /// out of range.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValue(uint index, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Look up an attribute's value by Namespace name.  If the attribute
        /// value is a list of tokens (IDREFS, ENTITIES, or NMTOKENS), the
        /// tokens will be concatenated into a single string with each token
        /// separated by a single space.
        ///
        /// @param uri The Namespace URI, or the empty string
        /// if the name has no Namespace URI.
        /// @param localName The attribute's local name.
        /// @return The attribute's value as a string, or null if the attribute is
        /// not in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueFromName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase uri, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Look up an attribute's value by XML qualified (prefixed) name.
        /// If the attribute value is a list of tokens (IDREFS, ENTITIES, or
        /// NMTOKENS), the tokens will be concatenated into a single string
        /// with each token separated by a single space.
        ///
        /// @param qName The qualified (prefixed) name.
        /// @return The attribute's value as a string, or null if the attribute is
        /// not in the list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetValueFromQName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase qName, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
	}
}
