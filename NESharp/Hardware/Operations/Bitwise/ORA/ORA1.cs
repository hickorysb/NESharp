using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - Immediate
public class ORA1 : Instruction
{
    public const byte OPCODE = 0x09;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ORA.OrA(cpu, operand);
        return 2;
    }
}