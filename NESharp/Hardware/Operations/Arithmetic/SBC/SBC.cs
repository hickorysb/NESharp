using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// GENERIC SBC CODE
public static class SBC
{
    public static void SubA(CPU cpu, byte value)
    {
        byte original = cpu.Registers.A.GetValue();
        int result = original + ~value + (cpu.Registers.P.Carry ? 1 : 0);
        cpu.Registers.P.SetBit(StatusBit.C, !(result < 0x00));
        cpu.Registers.P.SetBit(StatusBit.Z, result == 0);
        cpu.Registers.P.SetBit(StatusBit.V, ((result ^ cpu.Registers.A.GetValue()) & (result ^ ~value) & 0x80) != 0);
        cpu.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
        cpu.Registers.A.SetValue(Shorten(result));
    }
    
    public static void SubA(CPU cpu, ushort address)
    {
        SubA(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}