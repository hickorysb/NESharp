using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STY;

// STY - Absolute
public class STY3 : Instruction
{
    public const byte OPCODE = 0x8C;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        STY.StoreY(address);
        return 4;
    }
}