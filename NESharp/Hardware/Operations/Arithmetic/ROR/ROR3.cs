using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR3 : Instruction
{
    public const byte OPCODE = 0x76;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, ROR.RotateRight(address));
        return 6;
    }
}