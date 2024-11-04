using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Zero Page
public class AND2 : Instruction
{
    public const byte OPCODE = 0x25;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        AND.AndMem(address);
        return 3;
    }
}