using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.SEC;

public class SEC : Instruction
{
    public const byte OPCODE = 0x38;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, true);
        return 2;
    }
}