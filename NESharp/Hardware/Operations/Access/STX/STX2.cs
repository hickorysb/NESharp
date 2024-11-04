using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STX;

// STX - Zero Page, Y
public class STX2 : Instruction
{
    public const byte OPCODE = 0x96;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageY;

    public override int Call(ushort address)
    {
        STX.StoreX(address);
        return 4;
    }
}