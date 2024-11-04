using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPY;

// CPY - Absolute
public class CPY3 : Instruction
{
    public const byte OPCODE = 0xCC;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        CPY.CompY(address);
        return 4;
    }
}