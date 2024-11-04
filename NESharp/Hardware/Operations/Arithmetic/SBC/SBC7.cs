using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - (Indirect, X)
public class SBC7 : Instruction
{
    public const byte OPCODE = 0xE1;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectX;

    public override int Call(ushort address)
    {
        SBC.SubA(address);
        return 6;
    }
}