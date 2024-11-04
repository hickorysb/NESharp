using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX Absolute, Y
public class LDX5 : Instruction
{
    public const byte OPCODE = 0xBE;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteY;

    public override int Call(AddressDetails address)
    {
        LDX.LoadX(address.Address);
        return address.Crosses ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}