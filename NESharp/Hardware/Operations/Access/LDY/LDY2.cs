using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY - Zero Page
public class LDY2 : Instruction
{
    public const byte OPCODE = 0xA4;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        LDY.LoadY(address);
        return 3;
    }
}