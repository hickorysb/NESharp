using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY - Immediate
public class LDY1 : Instruction
{
    public const byte OPCODE = 0xA0;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        LDY.LoadY(value);
        return 2;
    }
}