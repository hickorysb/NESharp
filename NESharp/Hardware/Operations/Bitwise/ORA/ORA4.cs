using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - Absolute
public class ORA4 : Instruction
{
    public const byte OPCODE = 0x0D;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        ORA.OrA(address);
        return 4;
    }
}