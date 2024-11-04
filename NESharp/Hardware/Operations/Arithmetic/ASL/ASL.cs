using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public static class ASL
{
    public static byte ShiftLeft(byte value)
    {
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, (value & 0b1000_0000) != 0);

        value <<= 1;
        
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, value == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (value & 0b1000_0000) != 0);

        return value;
    }

    public static byte ShiftLeft(ushort address)
    {
        return ShiftLeft(Motherboard.RAM.ReadByte(address));
    }
}