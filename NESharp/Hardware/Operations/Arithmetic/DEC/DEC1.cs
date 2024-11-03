using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEC;

public class DEC1 : Instruction
{
    public const byte OPCODE = 0xC6;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        DEC.DecMem(cpu, zeroPageAddress);
        return 5;
    }
}