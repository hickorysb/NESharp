using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Absolute
public class SBC4 : Instruction
{
    public const byte OPCODE = 0xED;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        SBC.SubA(address);
        return 4;
    }
}