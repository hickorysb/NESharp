using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// GENERIC ADC CODE
public static class ADC
{
    public static void AddA(CPU cpu, byte value)
    {
        byte original = cpu.Registers.A.GetValue();
        ushort result = (ushort)(original + value + (cpu.Registers.P.Carry ? 1 : 0));
        cpu.Registers.P.SetBit(StatusBit.C, result > 0xFF);
        cpu.Registers.P.SetBit(StatusBit.Z, result == 0);
        cpu.Registers.P.SetBit(StatusBit.V, ((result ^ original) & (result ^ value) & 0x80) != 0);
        cpu.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
        cpu.Registers.A.SetValue(Shorten(result));
    }
    
    public static void AddA(CPU cpu, ushort address)
    {
        AddA(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}