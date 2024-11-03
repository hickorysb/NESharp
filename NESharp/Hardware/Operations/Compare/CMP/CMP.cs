using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP Generic Code
public static class CMP
{
    public static void CompA(CPU cpu, byte value)
    {
        ushort result = Shorten(cpu.Registers.A.GetValue() - value);
        cpu.Registers.P.SetBit(StatusBit.C, cpu.Registers.A.GetValue() >= value);
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.A.GetValue() == value);
        cpu.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }
    
    public static void CompA(CPU cpu, ushort address)
    {
        CompA(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}