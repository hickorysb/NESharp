using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// Generic EOR Code
public static class EOR
{
    public static void XorA(CPU cpu, byte value)
    {
        byte result = Shorten(cpu.Registers.A.GetValue() ^ value);
        cpu.Registers.A.SetValue(result);
        cpu.Registers.P.SetBit(StatusBit.Z, result == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }

    public static void XorA(CPU cpu, ushort address)
    {
        XorA(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}