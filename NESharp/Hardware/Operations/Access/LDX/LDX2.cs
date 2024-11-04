using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX - Zero Page
public class LDX2 : Instruction
{
    public const byte OPCODE = 0xA6;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        LDX.LoadX(address);
        return 3;
    }
}