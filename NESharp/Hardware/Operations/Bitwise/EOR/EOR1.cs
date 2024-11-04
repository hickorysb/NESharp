using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - Immediate
public class EOR1 : Instruction
{
    public const byte OPCODE = 0x49;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        EOR.XorA(value);
        return 2;
    }
}