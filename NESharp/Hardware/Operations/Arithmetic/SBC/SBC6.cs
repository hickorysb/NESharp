using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Absolute, Y
public class SBC6 : Instruction
{
    public const byte OPCODE = 0xF9;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteY;

    public override int Call(AddressDetails address)
    {
        SBC.SubA(address.Address);
        return address.Crosses ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}