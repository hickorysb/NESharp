using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// Generic LDX Code
public static class LDX
{
    public static void LoadX(CPU cpu, byte value)
    {
        cpu.Registers.X.SetValue(value);
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.X.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.X.GetValue() & 0b1000_0000) != 0);
    }

    public static void LoadX(CPU cpu, ushort address)
    {
        LoadX(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}