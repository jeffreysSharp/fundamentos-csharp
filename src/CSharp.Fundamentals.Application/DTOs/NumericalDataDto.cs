namespace CSharp.Fundamentals.Application.DTOs
{
    public class NumericalDataDto
    {
        public Guid Id { get; set; }
        public sbyte SmallValue { get; set; }
        public byte ByteValue { get; set; }
        public short ShortValue { get; set; }
        public ushort UShortValue { get; set; }
        public int IntValue { get; set; }
        public uint UIntValue { get; set; }
        public long LongValue { get;  set; }
        public ulong ULongValue { get; set; }
        public float FloatValue { get; set; }
        public double DoubleValue { get; set; }
        public decimal DecimalValue { get; set; }
    }
}
