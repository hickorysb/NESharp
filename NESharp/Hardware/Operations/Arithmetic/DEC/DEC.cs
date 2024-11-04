using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEC;

// Generic INC Code
public static class DEC
{
    public static void DecMem(ushort address)
    {
        byte val = Motherboard.RAM.ReadByte(address);
        val--;
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, val == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (val & 0b1000_0000) != 0);
        Motherboard.RAM.WriteByte(address, val);
    }
}