using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - (Indirect, X)
public class LDA7 : Instruction
{
    public const byte OPCODE = 0xA1;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectX;

    public override int Call(ushort address)
    {
        LDA.LoadA(address);
        return 6;
    }
}