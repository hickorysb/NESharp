using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - Immediate
public class ORA1 : Instruction
{
    public const byte OPCODE = 0x09;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        ORA.OrA(value);
        return 2;
    }
}