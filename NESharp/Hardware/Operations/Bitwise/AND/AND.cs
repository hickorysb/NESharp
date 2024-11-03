using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// Generic AND Code
public static class AND
{
    public static void AndMem(CPU cpu, byte value)
    {
        byte result = Shorten(cpu.Registers.A.GetValue() & value);
        cpu.Registers.A.SetValue(result);
        cpu.Registers.P.SetBit(StatusBit.Z, result == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }

    public static void AndMem(CPU cpu, ushort address)
    {
        AndMem(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}