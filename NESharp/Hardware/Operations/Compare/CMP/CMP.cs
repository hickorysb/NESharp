using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP Generic Code
public static class CMP
{
    public static void CompA(byte value)
    {
        ushort result = Shorten(Motherboard.CPU.Registers.A.GetValue() - value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, Motherboard.CPU.Registers.A.GetValue() >= value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.A.GetValue() == value);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }
    
    public static void CompA(ushort address)
    {
        CompA(Motherboard.RAM.ReadByte(address));
    }
}