using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INC;

// Generic INC Code
public static class INC
{
    public static void IncMem(ushort address)
    {
        byte val = Motherboard.RAM.ReadByte(address);
        val++;
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, val == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (val & 0b1000_0000) != 0);
        Motherboard.RAM.WriteByte(address, val);
    }
}