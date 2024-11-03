using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.RTS;

public class RTS : Instruction
{
    public const byte OPCODE = 0x60;
    
    public int Call(CPU cpu)
    {
        ushort counter = cpu.Motherboard.RAM.PopShort();
        cpu.Registers.PC.SetValue(AddUShorts(counter, 1));
        return 6;
    }
}