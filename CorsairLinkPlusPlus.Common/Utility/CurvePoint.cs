﻿#region LICENSE
/**
 * CorsairLinkPlusPlus
 * Copyright (c) 2014, Mark Dietzer & Simon Schick, All rights reserved.
 *
 * CorsairLinkPlusPlus is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or (at your option) any later version.
 *
 * CorsairLinkPlusPlus is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with CorsairLinkPlusPlus.
 */
 #endregion
using System.Collections.Generic;
namespace CorsairLinkPlusPlus.Common.Utility
{
    public class CurvePoint<K, V>
    {
        public CurvePoint()
        {

        }

        public CurvePoint(K x, V y)
        {
            this.X = x;
            this.Y = y;
        }

        public K X;
        public V Y;

        public override string ToString()
        {
            return "{x=" + X + ",y=" + Y + "}";
        }

        public static implicit operator CurvePoint<K, V>(Dictionary<string, object> value)
        {
            return new CurvePoint<K, V>((K)(dynamic)value["X"], (V)(dynamic)value["Y"]);
        }
    }
}
