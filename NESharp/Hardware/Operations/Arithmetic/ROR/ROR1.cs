using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROR;

public class ROR1 : Instruction
{
    public const byte OPCODE = 0x6A;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;

    public override int Call()
    {
        Motherboard.CPU.Registers.A.SetValue(ROR.RotateRight(Motherboard.CPU.Registers.A.GetValue()));
        return 2;
    }
}