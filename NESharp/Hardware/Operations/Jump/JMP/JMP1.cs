using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.JMP;

public class JMP1 : Instruction
{
    public const byte OPCODE = 0x4C;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.PC.SetValue(cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2)));
        return 3;
    }
}