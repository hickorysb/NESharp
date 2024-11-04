using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP - (Indirect, X)
public class CMP7 : Instruction
{
    public const byte OPCODE = 0xC1;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectX;

    public override int Call(ushort address)
    {
        CMP.CompA(address);
        return 6;
    }
}