using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Zero Page
public class SBC2 : Instruction
{
    public const byte OPCODE = 0xE5;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        SBC.SubA(address);
        return 3;
    }
}