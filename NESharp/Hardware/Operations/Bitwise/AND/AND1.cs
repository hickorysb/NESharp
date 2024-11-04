using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Immediate
public class AND1 : Instruction
{
    public const byte OPCODE = 0x29;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        AND.AndMem(value);
        return 2;
    }
}