using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Immediate
public class SBC1 : Instruction
{
    public const byte OPCODE = 0xE9;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        SBC.SubA(value);
        return 2;
    }
}