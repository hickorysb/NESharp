using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR3 : Instruction
{
    public const byte OPCODE = 0x56;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, LSR.ShiftRight(address));
        return 6;
    }
}