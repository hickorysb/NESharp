using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.INC;

public class INC3 : Instruction
{
    public const byte OPCODE = 0xEE;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        INC.IncMem(address);
        return 6;
    }
}