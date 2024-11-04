using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL4 : Instruction
{
    public const byte OPCODE = 0x2E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, ROL.RotateLeft(address));
        return 6;
    }
}