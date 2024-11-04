using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - (Indirect), Y
public class LDA8 : Instruction
{
    public const byte OPCODE = 0xB1;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectY;

    public override int Call(AddressDetails address)
    {
        LDA.LoadA(address.Address);
        return address.Crosses ? 6 : 5; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}