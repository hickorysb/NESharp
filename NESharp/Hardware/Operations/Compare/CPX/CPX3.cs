using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPX;

// CPX - Absolute
public class CPX3 : Instruction
{
    public const byte OPCODE = 0xEC;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        CPX.CompX(address);
        return 4;
    }
}