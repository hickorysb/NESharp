using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY - Zero Page, X
public class LDY3 : Instruction
{
    public const byte OPCODE = 0xB4;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;
    
    public override int Call(ushort address)
    {
        LDY.LoadY(address);
        return 4;
    }
}