using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL5 : Instruction
{
    public const byte OPCODE = 0x1E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteX;

    public override int Call(AddressDetails address)
    {
        Motherboard.RAM.WriteByte(address.Address, ASL.ShiftLeft(address.Address));
        return 7;
    }
}