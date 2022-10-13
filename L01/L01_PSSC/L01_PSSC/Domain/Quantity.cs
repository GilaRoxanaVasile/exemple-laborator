﻿using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_PSSC.Domain

{

    [AsChoice]
    public static partial class Quantity
    {
        public interface IQuantity { }
        public record QKg() : IQuantity
        {
            private double kg { get; }
            public QKg(double kg) : this()
            {
                this.kg = kg;
            }
        }
        public record QUnit() : IQuantity
        {
            private int unit { get; }
            public QUnit(int unit) : this()
            {
                this.unit = unit;
            }
        }
    }
}
