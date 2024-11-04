using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX - Zero Page, Y
public class LDX3 : Instruction
{
    public const byte OPCODE = 0xB6;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageY;
    
    public override int Call(ushort address)
    {
        LDX.LoadX(address);
        return 4;
    }
}