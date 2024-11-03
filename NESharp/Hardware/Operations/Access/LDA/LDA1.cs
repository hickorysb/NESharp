using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Immediate
public class LDA1 : Instruction
{
    public const byte OPCODE = 0xA9;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDA.LoadA(cpu, operand);
        return 2;
    }
}