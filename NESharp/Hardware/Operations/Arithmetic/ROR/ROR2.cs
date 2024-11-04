using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR2 : Instruction
{
    public const byte OPCODE = 0x66;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, ROR.RotateRight(address));
        return 5;
    }
}