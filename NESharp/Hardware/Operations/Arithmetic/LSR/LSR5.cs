using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR5 : Instruction
{
    public const byte OPCODE = 0x5E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteX;

    public override int Call(AddressDetails address)
    {
        Motherboard.RAM.WriteByte(address.Address, LSR.ShiftRight(address.Address));
        return 7;
    }
}