using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public static class ROL
{
    public static byte RotateLeft(byte value)
    {
        bool carry = Motherboard.CPU.Registers.P.Carry;
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, (value & 0b1000_0000) != 0);

        value <<= 1;

        if (carry)
        {
            value |= 1;
        }
        else
        {
            value &= 0b1000_0000;
        }
        
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, value == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (value & 0b1000_0000) != 0);

        return value;
    }

    public static byte RotateLeft(ushort address)
    {
        return RotateLeft(Motherboard.RAM.ReadByte(address));
    }
}