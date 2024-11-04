using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Absolute, X
public class STA4 : Instruction
{
    public const byte OPCODE = 0x9D;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteX;

    public override int Call(AddressDetails address)
    {
        STA.StoreA(address.Address);
        return 5;
    }
}