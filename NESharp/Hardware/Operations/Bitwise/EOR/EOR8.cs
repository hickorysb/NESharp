using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - (Indirect), Y
public class EOR8 : Instruction
{
    public const byte OPCODE = 0x51;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectY;

    public override int Call(AddressDetails address)
    {
        EOR.XorA(address.Address);
        return address.Crosses ? 6 : 5; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}