using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - (Indirect, X)
public class AND7 : Instruction
{
    public const byte OPCODE = 0x21;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectX;

    public override int Call(ushort address)
    {
        AND.AndMem(address);
        return 6;
    }
}