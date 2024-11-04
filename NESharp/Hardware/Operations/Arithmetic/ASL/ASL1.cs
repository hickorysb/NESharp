using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL1 : Instruction
{
    public const byte OPCODE = 0x0A;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;

    public override int Call()
    {
        Motherboard.CPU.Registers.A.SetValue(ASL.ShiftLeft(Motherboard.CPU.Registers.A.GetValue()));
        return 2;
    }
}