using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.BIT;

public static class BIT
{
    public static void BitTest(byte value)
    {
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, (Motherboard.CPU.Registers.A.GetValue() & value) == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.V, (Motherboard.CPU.Registers.A.GetValue()  & 0b0100_0000) != 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (Motherboard.CPU.Registers.A.GetValue() & 0b1000_0000) != 0);
    }

    public static void BitTest(ushort address)
    {
        BitTest(Motherboard.RAM.ReadByte(address));
    }
}