using System;
using System.Diagnostics;

namespace WolvenKit.RED4.Types
{
    [RED("Bool")]
    [DebuggerDisplay("{_value,nq}", Type = "CBool")]
    public readonly struct CBool : IRedPrimitive<bool>, IEquatable<CBool>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte _value;

        private CBool(byte value)
        {
            _value = value;
        }

        public static implicit operator CBool(byte value) => new(value);
        public static implicit operator byte(CBool value) => value._value;

        public static implicit operator CBool(bool value) => new(value ? (byte)1 : (byte)0);
        public static implicit operator bool(CBool value) => value._value != 0;

        public bool Equals(CBool other) => _value == other._value;

        public override bool Equals(object obj) => obj is CBool other && Equals(other);

        public override int GetHashCode() => _value.GetHashCode();
    }
}
