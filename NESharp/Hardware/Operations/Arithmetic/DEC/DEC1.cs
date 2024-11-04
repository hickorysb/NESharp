using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEC;

public class DEC1 : Instruction
{
    public const byte OPCODE = 0xC6;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        DEC.DecMem(address);
        return 5;
    }
}