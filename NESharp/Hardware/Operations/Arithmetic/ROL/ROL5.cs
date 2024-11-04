using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL5 : Instruction
{
    public const byte OPCODE = 0x3E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteX;

    public override int Call(AddressDetails address)
    {
        Motherboard.RAM.WriteByte(address.Address, ROL.RotateLeft(address.Address));
        return 7;
    }
}