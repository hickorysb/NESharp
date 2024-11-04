using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.BIT;

public class BIT1 : Instruction
{
    public const byte OPCODE = 0x24;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        BIT.BitTest(address);
        return 3;
    }
}