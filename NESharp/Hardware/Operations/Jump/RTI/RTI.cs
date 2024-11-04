using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.RTI;

public class RTI : Instruction
{
    public const byte OPCODE = 0x40;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        byte status = Motherboard.RAM.Pop();
        ushort counter = Motherboard.RAM.PopShort();
        Motherboard.CPU.Registers.P.ParseByte(status);
        Motherboard.CPU.Registers.PC.SetValue(counter);
        return 6;
    }
}