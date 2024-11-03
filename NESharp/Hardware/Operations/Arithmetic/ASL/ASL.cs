using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public static class ASL
{
    public static byte ShiftLeft(CPU cpu, byte value)
    {
        cpu.Registers.P.SetBit(StatusBit.C, (value & 0b1000_0000) != 0);

        value <<= 1;
        
        cpu.Registers.P.SetBit(StatusBit.Z, value == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (value & 0b1000_0000) != 0);

        return value;
    }

    public static byte ShiftLeft(CPU cpu, ushort address)
    {
        return ShiftLeft(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}