using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// Generic LDY Code
public static class LDY
{
    public static void LoadY(CPU cpu, byte value)
    {
        cpu.Registers.Y.SetValue(value);
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.Y.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.Y.GetValue() & 0b1000_0000) != 0);
    }

    public static void LoadY(CPU cpu, ushort address)
    {
        LoadY(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}