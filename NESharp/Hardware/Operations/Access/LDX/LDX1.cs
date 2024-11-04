using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX - Immediate
public class LDX1 : Instruction
{
    public const byte OPCODE = 0xA2;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        LDX.LoadX(value);
        return 2;
    }
}