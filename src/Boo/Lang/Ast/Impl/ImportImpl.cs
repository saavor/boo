#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Wed Feb 18 10:32:55 2004
//
using System;

namespace Boo.Lang.Ast.Impl
{
	[Serializable]
	public abstract class ImportImpl : Node
	{
		protected string _namespace;
		protected ReferenceExpression _assemblyReference;
		protected ReferenceExpression _alias;
		
		protected ImportImpl()
		{
 		}
		
		protected ImportImpl(string namespace_, ReferenceExpression assemblyReference, ReferenceExpression alias)
		{
 			Namespace = namespace_;
			AssemblyReference = assemblyReference;
			Alias = alias;
		}
		
		protected ImportImpl(LexicalInfo lexicalInfo, string namespace_, ReferenceExpression assemblyReference, ReferenceExpression alias) : base(lexicalInfo)
		{
 			Namespace = namespace_;				
			AssemblyReference = assemblyReference;				
			Alias = alias;				
		}
		
		protected ImportImpl(LexicalInfo lexicalInfo) : base(lexicalInfo)
		{
 		}
		
		public override NodeType NodeType
		{
			get
			{
				return NodeType.Import;
			}
		}
		public string Namespace
		{
			get
			{
				return _namespace;
			}
			
			set
			{
				
				_namespace = value;
			}
		}
		public ReferenceExpression AssemblyReference
		{
			get
			{
				return _assemblyReference;
			}
			
			set
			{
				
				if (_assemblyReference != value)
				{
					_assemblyReference = value;
					if (null != _assemblyReference)
					{
						_assemblyReference.InitializeParent(this);
					}
				}
			}
		}
		public ReferenceExpression Alias
		{
			get
			{
				return _alias;
			}
			
			set
			{
				
				if (_alias != value)
				{
					_alias = value;
					if (null != _alias)
					{
						_alias.InitializeParent(this);
					}
				}
			}
		}
		new public Import CloneNode()
		{
			return (Import)Clone();
		}
		
		override public object Clone()
		{
			Import clone = (Import)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(GetType());
			clone._lexicalInfo = _lexicalInfo;
			clone._documentation = _documentation;
			clone._properties = (System.Collections.Hashtable)_properties.Clone();
			
			clone._namespace = _namespace;
			if (null != _assemblyReference)
			{
				clone._assemblyReference = (ReferenceExpression)_assemblyReference.Clone();
			}
			if (null != _alias)
			{
				clone._alias = (ReferenceExpression)_alias.Clone();
			}
			
			return clone;
		}
		
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			
			if (_assemblyReference == existing)
			{
				this.AssemblyReference = (ReferenceExpression)newNode;
				return true;
			}
			if (_alias == existing)
			{
				this.Alias = (ReferenceExpression)newNode;
				return true;
			}
			return false;
		}
		
		override public void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			Import thisNode = (Import)this;
			Import resultingTypedNode = thisNode;
			transformer.OnImport(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}
	}
}
