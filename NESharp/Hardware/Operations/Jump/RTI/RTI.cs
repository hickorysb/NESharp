using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.RTI;

public class RTI : Instruction
{
    public const byte OPCODE = 0x40;
    
    public int Call(CPU cpu)
    {
        byte status = cpu.Motherboard.RAM.Pop();
        ushort counter = cpu.Motherboard.RAM.PopShort();
        cpu.Registers.P.ParseByte(status);
        cpu.Registers.PC.SetValue(counter);
        return 6;
    }
}