using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEC;

public class DEC2 : Instruction
{
    public const byte OPCODE = 0xD6;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;

    public override int Call(ushort address)
    {
        DEC.DecMem(address);
        return 6;
    }
}