using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// GENERIC ADC CODE
public static class ADC
{
    public static void AddA(byte value)
    {
        byte original = Motherboard.CPU.Registers.A.GetValue();
        ushort result = (ushort)(original + value + (Motherboard.CPU.Registers.P.Carry ? 1 : 0));
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, result > 0xFF);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, result == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.V, ((result ^ original) & (result ^ value) & 0x80) != 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
        Motherboard.CPU.Registers.A.SetValue(Shorten(result));
    }
    
    public static void AddA(ushort address)
    {
        AddA(Motherboard.RAM.ReadByte(address));
    }
}