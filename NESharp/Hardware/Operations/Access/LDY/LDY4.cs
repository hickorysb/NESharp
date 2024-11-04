using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY - Absolute
public class LDY4 : Instruction
{
    public const byte OPCODE = 0xAC;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        LDY.LoadY(address);
        return 4;
    }
}