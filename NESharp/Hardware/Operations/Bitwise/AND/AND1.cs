using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Immediate
public class AND1 : Instruction
{
    public const byte OPCODE = 0x29;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        AND.AndMem(cpu, operand);
        return 2;
    }
}