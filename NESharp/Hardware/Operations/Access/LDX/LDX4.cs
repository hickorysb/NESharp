using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX - Absolute
public class LDX4 : Instruction
{
    public const byte OPCODE = 0xAE;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        LDX.LoadX(address);
        return 4;
    }
}