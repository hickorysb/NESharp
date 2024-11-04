using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Absolute, X
public class LDA5 : Instruction
{
    public const byte OPCODE = 0xBD;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteX;

    public override int Call(AddressDetails address)
    {
        LDA.LoadA(address.Address);
        return address.Crosses ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}