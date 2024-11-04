using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// Generic LDY Code
public static class LDY
{
    public static void LoadY(byte value)
    {
        Motherboard.CPU.Registers.Y.SetValue(value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.Y.GetValue() == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (Motherboard.CPU.Registers.Y.GetValue() & 0b1000_0000) != 0);
    }

    public static void LoadY(ushort address)
    {
        LoadY(Motherboard.RAM.ReadByte(address));
    }
}