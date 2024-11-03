using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public static class ROR
{
    public static byte RotateRight(CPU cpu, byte value)
    {
        bool carry = cpu.Registers.P.Carry;
        cpu.Registers.P.SetBit(StatusBit.C, (value & 0b0000_0001) != 0);

        value >>= 1;
        
        if (carry)
        {
            value |= 0b1000_0000;
        }
        else
        {
            value &= 0b0111_1111;
        }
        
        cpu.Registers.P.SetBit(StatusBit.Z, value == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (value & 0b1000_0000) != 0);

        return value;
    }

    public static byte RotateRight(CPU cpu, ushort address)
    {
        return RotateRight(cpu, cpu.Motherboard.RAM.ReadByte(address));
    }
}