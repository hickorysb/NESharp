using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - (Indirect, X)
public class ORA7 : Instruction
{
    public const byte OPCODE = 0x01;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectX;

    public override int Call(ushort address)
    {
        ORA.OrA(address);
        return 6;
    }
}