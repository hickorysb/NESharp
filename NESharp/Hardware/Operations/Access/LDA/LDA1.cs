using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Immediate
public class LDA1 : Instruction
{
    public const byte OPCODE = 0xA9;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        LDA.LoadA(value);
        return 2;
    }
}