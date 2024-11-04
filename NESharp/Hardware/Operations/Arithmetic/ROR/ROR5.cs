using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR5 : Instruction
{
    public const byte OPCODE = 0x7E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteX;

    public override int Call(AddressDetails address)
    {
        Motherboard.RAM.WriteByte(address.Address, ROR.RotateRight(address.Address));
        return 7;
    }
}