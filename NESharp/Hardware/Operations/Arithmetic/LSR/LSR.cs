using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public static class LSR
{
    public static byte ShiftRight(CPU cpu, byte value)
    {
        cpu.Registers.P.SetBit(StatusBit.C, (value & 0b0000_0001) != 0);

        value >>= 1;
        
        cpu.Registers.P.SetBit(StatusBit.Z, value == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (value & 0b1000_0000) != 0);

        return value;
    }

    public static byte ShiftRight(CPU cpu, ushort address)
    {
        return ShiftRight(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}