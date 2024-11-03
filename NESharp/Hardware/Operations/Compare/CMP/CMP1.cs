using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP - Immediate
public class CMP1 : Instruction
{
    public const byte OPCODE = 0xC9;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        CMP.CompA(cpu, operand);
        return 2;
    }
}