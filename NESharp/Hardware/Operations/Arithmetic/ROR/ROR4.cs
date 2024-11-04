using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR4 : Instruction
{
    public const byte OPCODE = 0x6E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, ROR.RotateRight(address));
        return 6;
    }
}