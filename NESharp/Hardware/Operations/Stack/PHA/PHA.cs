using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.PHA;

public class PHA : Instruction
{
    public const byte OPCODE = 0x48;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;

    public override int Call()
    {
        Motherboard.RAM.Push(Motherboard.CPU.Registers.A.GetValue());
        return 3;
    }
}