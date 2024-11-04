using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Other.NOP;

public class NOP : Instruction
{
    public const byte OPCODE = 0xEA;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        return 2;
    }
}