using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Absolute, X
public class AND5 : Instruction
{
    public const byte OPCODE = 0x3D;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteX;

    public override int Call(AddressDetails address)
    {
        AND.AndMem(address.Address);
        return address.Crosses ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}