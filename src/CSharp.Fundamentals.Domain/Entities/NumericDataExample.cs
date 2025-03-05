namespace CSharp.Fundamentals.Domain.Entities
{
    public class NumericDataExample
    {
        public Guid Id { get; private set; }
        public sbyte SmallValue { get; private set; }
        public byte ByteValue { get; private set; }
        public short ShortValue { get; private set; }
        public ushort UShortValue { get; private set; }
        public int IntValue { get; private set; }
        public uint UIntValue { get; private set; }
        public long LongValue { get; private set; }
        public ulong ULongValue { get; private set; }
        public float FloatValue { get; private set; }
        public double DoubleValue { get; private set; }
        public decimal DecimalValue { get; private set; }

        public NumericDataExample(sbyte smallValue, byte byteValue, short shortValue, ushort ushortValue, int intValue, uint uintValue, long longValue, ulong ulongValue, float floatValue, double doubleValue, decimal decimalValue)
        {
            Id = Guid.NewGuid();
            SmallValue = smallValue;
            ByteValue = byteValue;
            ShortValue = shortValue;
            UShortValue = ushortValue;
            IntValue = intValue;
            UIntValue = uintValue;
            LongValue = longValue;
            ULongValue = ulongValue;
            FloatValue = floatValue;
            DoubleValue = doubleValue;
            DecimalValue = decimalValue;
        }
    }
}