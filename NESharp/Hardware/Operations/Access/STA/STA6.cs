using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - (Indirect, X)
public class STA6 : Instruction
{
    public const byte OPCODE = 0x81;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectX;

    public override int Call(ushort address)
    {
        STA.StoreA(address);
        return 6;
    }
}