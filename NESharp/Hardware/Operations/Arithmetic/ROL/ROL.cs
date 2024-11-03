using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public static class ROL
{
    public static byte RotateLeft(CPU cpu, byte value)
    {
        bool carry = cpu.Registers.P.Carry;
        cpu.Registers.P.SetBit(StatusBit.C, (value & 0b1000_0000) != 0);

        value <<= 1;

        if (carry)
        {
            value |= 1;
        }
        else
        {
            value &= 0b1000_0000;
        }
        
        cpu.Registers.P.SetBit(StatusBit.Z, value == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (value & 0b1000_0000) != 0);

        return value;
    }

    public static byte RotateLeft(CPU cpu, ushort address)
    {
        return RotateLeft(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}