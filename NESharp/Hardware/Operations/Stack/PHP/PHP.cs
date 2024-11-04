using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.PHP;

public class PHP : Instruction
{
    public const byte OPCODE = 0x08;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;

    public override int Call()
    {
        Motherboard.CPU.Registers.P.SetBit(StatusBit.B, true);
        Motherboard.RAM.Push(Motherboard.CPU.Registers.P.BuildByte());
        Motherboard.CPU.Registers.P.SetBit(StatusBit.B, false);
        return 3;
    }
}