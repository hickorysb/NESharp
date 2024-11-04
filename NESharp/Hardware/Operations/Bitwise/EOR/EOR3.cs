using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - Zero Page, X
public class EOR3 : Instruction
{
    public const byte OPCODE = 0x55;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;
    
    public override int Call(ushort address)
    {
        EOR.XorA(address);
        return 4;
    }
}