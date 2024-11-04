using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - (Indirect), Y
public class SBC8 : Instruction
{
    public const byte OPCODE = 0xF1;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectY;

    public override int Call(AddressDetails address)
    { ;
        SBC.SubA(address.Address);
        return address.Crosses ? 6 : 5; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}