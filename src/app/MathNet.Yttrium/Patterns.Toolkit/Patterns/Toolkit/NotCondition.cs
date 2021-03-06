#region Math.NET Yttrium (GPL) by Christoph Ruegg
// Math.NET Yttrium, part of the Math.NET Project
// https://yttrium.mathdotnet.com
//
// Copyright (c) 2001-2007, Christoph R�egg,  http://christoph.ruegg.name
//						
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace MathNet.Symbolics.Patterns.Toolkit
{
    public class NotCondition : Condition
    {
        private Condition _condition;

        public NotCondition(Condition condition)
        {
            _condition = condition;
        }

        public override bool FulfillsCondition(Signal output, Port port)
        {
            return !_condition.FulfillsCondition(output, port);
        }

        public override bool Equals(Condition other)
        {
            NotCondition ot = other as NotCondition;
            if(ot == null)
                return false;
            return _condition.Equals(ot._condition);
        }
    }
}
