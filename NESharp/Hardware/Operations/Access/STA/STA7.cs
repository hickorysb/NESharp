using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - (Indirect), Y
public class STA7 : Instruction
{
    public const byte OPCODE = 0x91;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectY;

    public override int Call(AddressDetails address)
    {
        STA.StoreA(address.Address);
        return 6;
    }
}