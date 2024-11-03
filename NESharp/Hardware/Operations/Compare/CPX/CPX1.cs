using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPX;

// CPX - Immediate
public class CPX1 : Instruction
{
    public const byte OPCODE = 0xE0;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        CPX.CompX(cpu, operand);
        return 2;
    }
}