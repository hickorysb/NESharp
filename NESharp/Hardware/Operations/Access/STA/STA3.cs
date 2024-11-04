using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Absolute
public class STA3 : Instruction
{
    public const byte OPCODE = 0x8D;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        STA.StoreA(address);
        return 4;
    }
}