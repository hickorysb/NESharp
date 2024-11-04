using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL2 : Instruction
{
    public const byte OPCODE = 0x26;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, ROL.RotateLeft(address));
        return 5;
    }
}