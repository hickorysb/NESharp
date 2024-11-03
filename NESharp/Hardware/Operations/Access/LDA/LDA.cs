using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// Generic LDA Code
public static class LDA
{
    public static void LoadA(CPU cpu, byte value)
    {
        cpu.Registers.A.SetValue(value);
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.A.GetValue() == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (cpu.Registers.A.GetValue() & 0b1000_0000) != 0);
    }

    public static void LoadA(CPU cpu, ushort address)
    {
        LoadA(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}