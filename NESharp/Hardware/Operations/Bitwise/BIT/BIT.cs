using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.BIT;

public static class BIT
{
    public static void BitTest(CPU cpu, byte value)
    {
        cpu.Registers.P.SetBit(StatusBit.Z, (cpu.Registers.A.GetValue() & value) == 0);
        cpu.Registers.P.SetBit(StatusBit.V, (cpu.Registers.A.GetValue()  & 0b0100_0000) != 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.A.GetValue() & 0b1000_0000) != 0);
    }

    public static void BitTest(CPU cpu, ushort address)
    {
        BitTest(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}