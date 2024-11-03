using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Immediate
public class SBC1 : Instruction
{
    public const byte OPCODE = 0xE9;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        SBC.SubA(cpu, operand);
        return 2;
    }
}