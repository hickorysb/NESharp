using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY - Immediate
public class LDY1 : Instruction
{
    public const byte OPCODE = 0xA0;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDY.LoadY(cpu, operand);
        return 2;
    }
}