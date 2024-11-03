using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEC;

// Generic INC Code
public static class DEC
{
    public static void DecMem(CPU cpu, ushort address)
    {
        byte val = cpu.Motherboard.RAM.ReadByte(address);
        val--;
        cpu.Registers.P.SetBit(StatusBit.Z, val == 0);
        cpu.Registers.P.SetBit(StatusBit.N, (val & 0b1000_0000) != 0);
        cpu.Motherboard.RAM.WriteByte(address, val);
    }
}