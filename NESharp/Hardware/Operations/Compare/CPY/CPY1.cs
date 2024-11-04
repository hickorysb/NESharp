using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPY;

// CPY - Immediate
public class CPY1 : Instruction
{
    public const byte OPCODE = 0xC0;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        CPY.CompY(value);
        return 2;
    }
}