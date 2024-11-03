using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// Generic ORA Code
public static class ORA
{
    public static void OrA(CPU cpu, byte value)
    {
        byte result = Shorten(cpu.Registers.A.GetValue() | value);
        cpu.Registers.A.SetValue(result);
        cpu.Registers.P.SetBit(StatusBit.Z, result == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }

    public static void OrA(CPU cpu, ushort address)
    {
        OrA(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}