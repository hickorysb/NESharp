using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Flags.CLC;

public class CLC : Instruction
{
    public const byte OPCODE = 0x18;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.P.SetBit(StatusBit.C, false);
        return 2;
    }
}