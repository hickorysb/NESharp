using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - Zero Page
public class EOR2 : Instruction
{
    public const byte OPCODE = 0x45;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        EOR.XorA(address);
        return 3;
    }
}