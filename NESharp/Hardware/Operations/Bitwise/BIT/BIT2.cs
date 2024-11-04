using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.BIT;

public class BIT2 : Instruction
{
    public const byte OPCODE = 0x2C;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        BIT.BitTest(address);
        return 4;
    }
}