using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR2 : Instruction
{
    public const byte OPCODE = 0x66;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        cpu.Motherboard.RAM.WriteByte(zeroPageAddress, ROR.RotateRight(cpu, zeroPageAddress));
        return 5;
    }
}