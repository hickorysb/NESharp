using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL3 : Instruction
{
    public const byte OPCODE = 0x16;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, ASL.ShiftLeft(address));
        return 6;
    }
}