using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR4 : Instruction
{
    public const byte OPCODE = 0x4E;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, LSR.ShiftRight(address));
        return 6;
    }
}