using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public static class ROR
{
    public static byte RotateRight(byte value)
    {
        bool carry = Motherboard.CPU.Registers.P.Carry;
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, (value & 0b0000_0001) != 0);

        value >>= 1;
        
        if (carry)
        {
            value |= 0b1000_0000;
        }
        else
        {
            value &= 0b0111_1111;
        }
        
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, value == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (value & 0b1000_0000) != 0);

        return value;
    }

    public static byte RotateRight(ushort address)
    {
        return RotateRight(Motherboard.RAM.ReadByte(address));
    }
}