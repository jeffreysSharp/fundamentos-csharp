using CSharp.Fundamentals.Domain.Entities;

namespace CSharp.Fundamentals.Application.Services
{
    public class NumericCalculatorService
    {
        public int Sum(int a, int b) => a + b;
        public long MultiplyLong(long a, long b) => a * b;
        public float DivideFloat(float a, float b) => b == 0 ? float.NaN : a / b;
        public ulong AddUlong(ulong a, ulong b) => a + b;

        public NumericalData PerformCalculations(NumericalData data)
        {
            return new NumericalData(
                (sbyte)(data.SmallValue + 1),
                (byte)(data.ByteValue + 2),
                (short)(data.ShortValue * 2),
                (ushort)(data.UShortValue + 100),
                data.IntValue + 10,
                data.UIntValue + 1000,
                data.LongValue * 2,
                data.ULongValue / 2,
                data.FloatValue * 1.5f,
                data.DoubleValue * 3.14159265359,
                data.DecimalValue * 99.99m
            );
        }
    }
}