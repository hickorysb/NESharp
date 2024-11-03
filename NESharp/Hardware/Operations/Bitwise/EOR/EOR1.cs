using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - Immediate
public class EOR1 : Instruction
{
    public const byte OPCODE = 0x49;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        EOR.XorA(cpu, operand);
        return 2;
    }
}