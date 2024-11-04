using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.PLP;

public class PLP : Instruction
{
    public const byte OPCODE = 0x28;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;

    public override int Call()
    {
        byte status = Motherboard.RAM.Pop();
        Motherboard.CPU.Registers.P.ParseByte(status);
        return 4;
    }
}