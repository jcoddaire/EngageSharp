﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngageSharp.Extensions
{
    public class Intervals : IEnumerable
    {
        public Interval Key { get; set; }
        public int Value { get; set; }

        public Intervals(Interval Key, int Value)
        {
            this.Key = Key;
            this.Value = Value;
        }

        public sealed class Interval
        {
            private readonly string name;

            public static readonly Interval Year = new Interval("year");
            public static readonly Interval Month = new Interval("month");
            public static readonly Interval Day = new Interval("day");
            public static readonly Interval Hour = new Interval("hour");
            public static readonly Interval Minute = new Interval("minute");
            public static readonly Interval Second = new Interval("second");

            private Interval(string name)
            {
                this.name = name;
            }

            public override string ToString()
            {
                return this.name;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
