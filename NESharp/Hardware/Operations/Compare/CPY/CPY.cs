using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPY;

// CPY Generic Code
public static class CPY
{
    public static void CompY(CPU cpu, byte value)
    {
        ushort result = Shorten(cpu.Registers.Y.GetValue() - value);
        cpu.Registers.P.SetBit(StatusBit.C, cpu.Registers.Y.GetValue() >= value);
        cpu.Registers.P.SetBit(StatusBit.Z, cpu.Registers.Y.GetValue() == value);
        cpu.Registers.P.SetBit(StatusBit.N, (result & 0b1000_0000) != 0);
    }
    
    public static void CompY(CPU cpu, ushort address)
    {
        CompY(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}