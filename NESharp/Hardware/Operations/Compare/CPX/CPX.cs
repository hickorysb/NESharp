using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPX;

// CPX Generic Code
public static class CPX
{
    public static void CompX(CPU cpu, byte value)
    {
        ushort result = Shorten(cpu.Registers.X.GetValue() - value);
        cpu.Registers.P.SetBit(StatusBit.C, cpu.Registers.X.GetValue() >= value);
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.X.GetValue() == value);
        cpu.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }
    
    public static void CompX(CPU cpu, ushort address)
    {
        CompX(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}