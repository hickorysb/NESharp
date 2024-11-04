using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP - Immediate
public class CMP1 : Instruction
{
    public const byte OPCODE = 0xC9;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        CMP.CompA(value);
        return 2;
    }
}