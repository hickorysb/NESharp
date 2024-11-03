using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX - Immediate
public class LDX1 : Instruction
{
    public const byte OPCODE = 0xA2;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDX.LoadX(cpu, operand);
        return 2;
    }
}