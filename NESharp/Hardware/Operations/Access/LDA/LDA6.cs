using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Absolute, Y
public class LDA6 : Instruction
{
    public const byte OPCODE = 0xB9;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteY;

    public override int Call(AddressDetails address)
    {
        LDA.LoadA(address.Address);
        return address.Crosses ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}