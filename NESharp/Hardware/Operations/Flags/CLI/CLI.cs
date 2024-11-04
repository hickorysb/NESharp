using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.CLI;

public class CLI : Instruction
{
    public const byte OPCODE = 0x58;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.P.SetBit(StatusBit.I, false);
        return 2;
    }
}