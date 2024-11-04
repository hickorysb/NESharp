using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// Generic LDX Code
public static class LDX
{
    public static void LoadX(byte value)
    {
        Motherboard.CPU.Registers.X.SetValue(value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.X.GetValue() == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (Motherboard.CPU.Registers.X.GetValue() & 0b1000_0000) != 0);
    }

    public static void LoadX(ushort address)
    {
        LoadX(Motherboard.RAM.ReadByte(address));
    }
}