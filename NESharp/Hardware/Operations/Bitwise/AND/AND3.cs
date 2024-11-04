using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Zero Page, X
public class AND3 : Instruction
{
    public const byte OPCODE = 0x35;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;
    
    public override int Call(ushort address)
    {
        AND.AndMem(address);
        return 4;
    }
}