using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STY;

// STY - Zero Page
public class STY1 : Instruction
{
    public const byte OPCODE = 0x84;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        STY.StoreY(address);
        return 3;
    }
}