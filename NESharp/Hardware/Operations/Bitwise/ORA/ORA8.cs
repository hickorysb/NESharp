using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - (Indirect), Y
public class ORA8 : Instruction
{
    public const byte OPCODE = 0x11;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectY;

    public override int Call(AddressDetails address)
    {
        ORA.OrA(address.Address);
        return address.Crosses ? 6 : 5; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}