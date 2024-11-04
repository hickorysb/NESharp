using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// GENERIC SBC CODE
public static class SBC
{
    public static void SubA(byte value)
    {
        byte original = Motherboard.CPU.Registers.A.GetValue();
        int result = original + ~value + (Motherboard.CPU.Registers.P.Carry ? 1 : 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, !(result < 0x00));
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, result == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.V, ((result ^ Motherboard.CPU.Registers.A.GetValue()) & (result ^ ~value) & 0x80) != 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
        Motherboard.CPU.Registers.A.SetValue(Shorten(result));
    }
    
    public static void SubA(ushort address)
    {
        SubA(Motherboard.RAM.ReadByte(address));
    }
}