using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// Generic AND Code
public static class AND
{
    public static void AndMem(byte value)
    {
        byte result = Shorten(Motherboard.CPU.Registers.A.GetValue() & value);
        Motherboard.CPU.Registers.A.SetValue(result);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, result == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }

    public static void AndMem(ushort address)
    {
        AndMem(Motherboard.RAM.ReadByte(address));
    }
}