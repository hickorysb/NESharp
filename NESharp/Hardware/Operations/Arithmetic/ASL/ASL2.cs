using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL2 : Instruction
{
    public const byte OPCODE = 0x06;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        Motherboard.RAM.WriteByte(address, ASL.ShiftLeft(address));
        return 5;
    }
}