using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INC;

public class INC4 : Instruction
{
    public const byte OPCODE = 0xFE;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.AbsoluteX;

    public override int Call(AddressDetails address)
    {
        INC.IncMem(address.Address);
        return 7;
    }
}