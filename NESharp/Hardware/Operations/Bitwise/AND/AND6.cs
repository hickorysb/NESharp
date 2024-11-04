using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Absolute, Y
public class AND6 : Instruction
{
    public const byte OPCODE = 0x39;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteY;

    public override int Call(AddressDetails address)
    {
        AND.AndMem(address.Address);
        return address.Crosses ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}