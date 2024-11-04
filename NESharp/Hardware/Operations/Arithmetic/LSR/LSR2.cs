using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR2 : Instruction
{
    public const byte OPCODE = 0x46;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, LSR.ShiftRight(address));
        return 5;
    }
}