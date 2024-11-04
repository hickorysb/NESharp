using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPX;

// CPX - Immediate
public class CPX1 : Instruction
{
    public const byte OPCODE = 0xE0;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        CPX.CompX(value);
        return 2;
    }
}