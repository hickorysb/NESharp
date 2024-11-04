using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL4 : Instruction
{
    public const byte OPCODE = 0x0E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, ASL.ShiftLeft(address));
        return 6;
    }
}