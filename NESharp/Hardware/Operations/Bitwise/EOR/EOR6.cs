using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - Absolute, Y
public class EOR6 : Instruction
{
    public const byte OPCODE = 0x59;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteY;

    public override int Call(AddressDetails address)
    {
        EOR.XorA(address.Address);
        return address.Crosses ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}