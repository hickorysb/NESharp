using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.JSR;

public class JSR : Instruction
{
    public const byte OPCODE = 0x20;
    
    public int Call(CPU cpu)
    {
        cpu.Motherboard.RAM.PushShort(AddUShorts(cpu.Registers.PC.GetValue(), 1));
        cpu.Registers.PC.SetValue(cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment()));
        return 6;
    }
}