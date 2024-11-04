using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// Generic LDA Code
public static class LDA
{
    public static void LoadA(byte value)
    {
        Motherboard.CPU.Registers.A.SetValue(value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.A.GetValue() == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (Motherboard.CPU.Registers.A.GetValue() & 0b1000_0000) != 0);
    }

    public static void LoadA(ushort address)
    {
        LoadA(Motherboard.RAM.ReadByte(address));
    }
}