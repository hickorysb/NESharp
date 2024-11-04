using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - Absolute
public class EOR4 : Instruction
{
    public const byte OPCODE = 0x4D;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        EOR.XorA(address);
        return 4;
    }
}