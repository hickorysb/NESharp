using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.SEI;

public class SEI : Instruction
{
    public const byte OPCODE = 0x78;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.P.SetBit(StatusBit.I, false);
        return 2;
    }
}