using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPY;

// CPY - Immediate
public class CPY1 : Instruction
{
    public const byte OPCODE = 0xC0;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        CPY.CompY(cpu, operand);
        return 2;
    }
}