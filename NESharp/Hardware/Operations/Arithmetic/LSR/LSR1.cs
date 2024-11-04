using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR1 : Instruction
{
    public const byte OPCODE = 0x4A;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;

    public override int Call()
    {
        Motherboard.CPU.Registers.A.SetValue(LSR.ShiftRight(Motherboard.CPU.Registers.A.GetValue()));
        return 2;
    }
}