using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.CLD;

public class CLD : Instruction
{
    public const byte OPCODE = 0xD8;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.P.SetBit(StatusBit.D, false);
        return 2;
    }
}