using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL1 : Instruction
{
    public const byte OPCODE = 0x2A;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;

    public override int Call()
    {
        Motherboard.CPU.Registers.A.SetValue(ROL.RotateLeft(Motherboard.CPU.Registers.A.GetValue()));
        return 2;
    }
}