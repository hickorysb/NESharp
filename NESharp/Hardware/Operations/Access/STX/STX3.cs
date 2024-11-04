using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STX;

// STA - Absolute
public class STX3 : Instruction
{
    public const byte OPCODE = 0x8E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        STX.StoreX(address);
        return 4;
    }
}