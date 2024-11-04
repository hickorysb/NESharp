namespace NESharp.Utilities;

public static class CPUMath
{
    public static ushort AddUShorts(ushort a, ushort b)
    {
        return (ushort)(a + b);
    }
    
    public static ushort SubUShorts(ushort a, ushort b)
    {
        return (ushort)(a - b);
    }

    public static byte Shorten(ushort a)
    {
        return (byte)(a & 0xFF);
    }
    
    public static byte Shorten(int a)
    {
        return (byte)(a & 0xFF);
    }
}