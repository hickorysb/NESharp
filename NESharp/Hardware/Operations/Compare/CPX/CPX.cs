using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPX;

// CPX Generic Code
public static class CPX
{
    public static void CompX(byte value)
    {
        ushort result = Shorten(Motherboard.CPU.Registers.X.GetValue() - value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, Motherboard.CPU.Registers.X.GetValue() >= value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.X.GetValue() == value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }
    
    public static void CompX(ushort address)
    {
        CompX(Motherboard.RAM.ReadByte(address));
    }
}