/* 
 * Copyright (C) 1999-2009 John K�ll�n.
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Decompiler.Core.Lib
{
    /// <summary>
    /// Provides an unordered set with an O(1) contains method.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HashSet<T>
    {
        private Dictionary<T, int> set;

        public HashSet()
        {
            set = new Dictionary<T, int>();
        }

        public void Add(T t)
        {
            set[t] = 1;
        }

        public bool Contains(T t)
        {
            return set.ContainsKey(t);
        }

        public bool Remove(T t)
        {
            return set.Remove(t);
        }
    }

}