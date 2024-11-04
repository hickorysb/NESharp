using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Absolute, Y
public class STA5 : Instruction
{
    public const byte OPCODE = 0x99;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteY;

    public override int Call(AddressDetails address)
    {
        STA.StoreA(address.Address);
        return 5;
    }
}