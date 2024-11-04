using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - (Indirect, X)
public class EOR7 : Instruction
{
    public const byte OPCODE = 0x41;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectX;

    public override int Call(ushort address)
    {
        EOR.XorA(address);
        return 6;
    }
}