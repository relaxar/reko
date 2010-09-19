#region License
/* 
 * Copyright (C) 1999-2010 John K�ll�n.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2, or (at your option)
 * any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; see the file COPYING.  If not, write to
 * the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.
 */
#endregion

using System;
using Decompiler.Core.Types;

namespace Decompiler.Core.Code
{
	/// <summary>
	/// Corresponds to the :: operator of C++; 
	/// </summary>
	public class ScopeResolution : Expression
	{
		private string name;

		public ScopeResolution(DataType dt, string typeName) : base(dt)
		{
			this.name = typeName;
		}

		public override Expression Accept(IExpressionTransformer xform)
		{
			return xform.TransformScopeResolution(this);
		}

		public override void Accept(IExpressionVisitor visit)
		{
			visit.VisitScopeResolution(this);
		}

		public override Expression CloneExpression()
		{
			return new ScopeResolution(DataType, name);
		}

		public string TypeName
		{
			get { return name; }
		}
	}

}