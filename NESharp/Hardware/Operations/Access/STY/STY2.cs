using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STY;

// STY - Zero Page, X
public class STY2 : Instruction
{
    public const byte OPCODE = 0x94;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;

    public override int Call(ushort address)
    {
        STY.StoreY(address);
        return 4;
    }
}