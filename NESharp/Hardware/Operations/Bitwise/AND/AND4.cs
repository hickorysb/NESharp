using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Absolute
public class AND4 : Instruction
{
    public const byte OPCODE = 0x2D;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        AND.AndMem(address);
        return 4;
    }
}