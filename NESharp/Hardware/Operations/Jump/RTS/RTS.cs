using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.RTS;

public class RTS : Instruction
{
    public const byte OPCODE = 0x60;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        ushort counter = Motherboard.RAM.PopShort();
        Motherboard.CPU.Registers.PC.SetValue(AddUShorts(counter, 1));
        return 6;
    }
}