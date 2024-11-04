using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP - Absolute
public class CMP4 : Instruction
{
    public const byte OPCODE = 0xCD;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        CMP.CompA(address);
        return 4;
    }
}