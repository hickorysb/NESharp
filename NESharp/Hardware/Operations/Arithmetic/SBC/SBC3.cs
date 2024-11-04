using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Zero Page, X
public class SBC3 : Instruction
{
    public const byte OPCODE = 0xF5;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;

    public override int Call(ushort address)
    {
        SBC.SubA(address);
        return 4;
    }
}