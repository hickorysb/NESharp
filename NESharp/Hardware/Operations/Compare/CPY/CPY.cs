using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPY;

// CPY Generic Code
public static class CPY
{
    public static void CompY(byte value)
    {
        ushort result = Shorten(Motherboard.CPU.Registers.Y.GetValue() - value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, Motherboard.CPU.Registers.Y.GetValue() >= value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.Y.GetValue() == value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }
    
    public static void CompY(ushort address)
    {
        CompY(Motherboard.RAM.ReadByte(address));
    }
}