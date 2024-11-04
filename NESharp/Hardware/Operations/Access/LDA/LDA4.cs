using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Absolute
public class LDA4 : Instruction
{
    public const byte OPCODE = 0xAD;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        LDA.LoadA(address);
        return 4;
    }
}