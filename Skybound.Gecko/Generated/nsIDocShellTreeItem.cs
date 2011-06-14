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
// Generated by IDLImporter from file nsIDocShellTreeItem.idl
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
	
	
	/// <summary>
    /// The nsIDocShellTreeItem supplies the methods that are required of any item
    /// that wishes to be able to live within the docshell tree either as a middle
    /// node or a leaf.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("09b54ec1-d98a-49a9-bc95-3219e8b55089")]
	public interface nsIDocShellTreeItem : nsIDocShellTreeNode
	{
		
		/// <summary>
        ///The current number of DocShells which are immediate children of the
        ///	this object.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetChildCountAttribute();
		
		/// <summary>
        ///Add a new child DocShellTreeItem.  Adds to the end of the list.
        ///	Note that this does NOT take a reference to the child.  The child stays
        ///	alive only as long as it's referenced from outside the docshell tree.
        ///	@throws NS_ERROR_ILLEGAL_VALUE if child corresponds to the same
        ///	        object as this treenode or an ancestor of this treenode
        ///	@throws NS_ERROR_UNEXPECTED if this node is a leaf in the tree.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddChild([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem child);
		
		/// <summary>
        ///Removes a child DocShellTreeItem.
        ///	@throws NS_ERROR_UNEXPECTED if this node is a leaf in the tree.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem child);
		
		/// <summary>
        /// Return the child at the index requested.  This is 0-based.
        ///
        /// @throws NS_ERROR_UNEXPECTED if the index is out of range
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDocShellTreeItem GetChildAt(int index);
		
		/// <summary>
        ///Return the child DocShellTreeItem with the specified name.
        ///	aName - This is the name of the item that is trying to be found.
        ///	aRecurse - Is used to tell the function to recurse through children.
        ///		Note, recursion will only happen through items of the same type.
        ///	aSameType - If this is set only children of the same type will be returned.
        ///	aRequestor - This is the docshellTreeItem that is requesting the find.  This
        ///		parameter is used when recursion is being used to avoid searching the same
        ///		tree again when a child has asked a parent to search for children.
        ///	aOriginalRequestor - The original treeitem that made the request, if any.
        ///    	This is used to ensure that we don't run into cross-site issues.
        ///	Note the search is depth first when recursing.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDocShellTreeItem FindChildWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName, [MarshalAs(UnmanagedType.Bool)] bool aRecurse, [MarshalAs(UnmanagedType.Bool)] bool aSameType, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);
		
		/// <summary>
        ///name of the DocShellTreeItem
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetNameAttribute();
		
		/// <summary>
        ///name of the DocShellTreeItem
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aName);
		
		/// <summary>
        /// Compares the provided name against the item's name and
        /// returns the appropriate result.
        ///
        /// @return <CODE>PR_TRUE</CODE> if names match;
        /// <CODE>PR_FALSE</CODE> otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NameEquals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string name);
		
		/// <summary>
        ///The type this item is.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemTypeAttribute();
		
		/// <summary>
        ///The type this item is.
        ///	 </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemTypeAttribute(int aItemType);
		
		/// <summary>
        ///Parent DocShell.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetParentAttribute();
		
		/// <summary>
        ///This is call returns the same thing parent does however if the parent is
        ///	of a different itemType, it will instead return nsnull.  This call is a
        ///	convience function for those wishing to not cross the boundaries at which
        ///	item types change.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeParentAttribute();
		
		/// <summary>
        ///Returns the root DocShellTreeItem.  This is a convience equivalent to
        ///	getting the parent and its parent until there isn't a parent.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetRootTreeItemAttribute();
		
		/// <summary>
        ///Returns the root DocShellTreeItem of the same type.  This is a convience
        ///	equivalent to getting the parent of the same type and its parent until
        ///	there isn't a parent.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeRootTreeItemAttribute();
		
		/// <summary>
        ///Returns the docShellTreeItem with the specified name.  Search order is as
        ///	follows...
        ///	1.)  Check name of self, if it matches return it.
        ///	2.)  For each immediate child.
        ///		a.) Check name of child and if it matches return it.
        ///		b.)  Ask the child to perform the check
        ///			i.) Do not ask a child if it is the aRequestor
        ///			ii.) Do not ask a child if it is of a different item type.
        ///	3.)  If there is a parent of the same item type ask parent to perform the check
        ///		a.) Do not ask parent if it is the aRequestor
        ///	4.)  If there is a tree owner ask the tree owner to perform the check
        ///		a.)  Do not ask the tree owner if it is the aRequestor
        ///		b.)  This should only be done if there is no parent of the same type.
        ///	Return the child DocShellTreeItem with the specified name.
        ///	name - This is the name of the item that is trying to be found.
        ///	aRequestor - This is the object that is requesting the find.  This
        ///		parameter is used to identify when the child is asking its parent to find
        ///		a child with the specific name.  The parent uses this parameter to ensure
        ///		a resursive state does not occur by not again asking the requestor to find
        ///		a shell by the specified name.  Inversely the child uses it to ensure it
        ///		does not ask its parent to do the search if its parent is the one that
        ///		asked it to search.  Children also use this to test against the treeOwner;
        ///	aOriginalRequestor - The original treeitem that made the request, if any.
        ///		This is used to ensure that we don't run into cross-site issues.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string name, [MarshalAs(UnmanagedType.Interface)] nsISupports aRequestor, [MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeItem aOriginalRequestor);
		
		/// <summary>
        ///The owner of the DocShell Tree.  This interface will be called upon when
        ///	the docshell has things it needs to tell to the owner of the docshell.
        ///	Note that docShell tree ownership does not cross tree types.  Meaning
        ///	setting ownership on a chrome tree does not set ownership on the content
        ///	sub-trees.  A given tree's boundaries are identified by the type changes.
        ///	Trees of different types may be connected, but should not be traversed
        ///	for things such as ownership.
        ///	
        ///	Note implementers of this interface should NOT effect the lifetime of the
        ///	parent DocShell by holding this reference as it creates a cycle.  Owners
        ///	when releasing this interface should set the treeOwner to nsnull.
        ///	Implementers of this interface are guaranteed that when treeOwner is
        ///	set that the poitner is valid without having to addref.
        ///	
        ///	Further note however when others try to get the interface it should be
        ///	addref'd before handing it to them.
        ///	 </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeOwner GetTreeOwnerAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTreeOwner([MarshalAs(UnmanagedType.Interface)] nsIDocShellTreeOwner treeOwner);
	}
}
