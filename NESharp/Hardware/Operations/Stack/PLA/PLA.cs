using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.PLA;

public class PLA : Instruction
{
    public const byte OPCODE = 0x68;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;

    public override int Call()
    {
        byte status = Motherboard.RAM.Pop();
        Motherboard.CPU.Registers.A.SetValue(status);
        return 4;
    }
}