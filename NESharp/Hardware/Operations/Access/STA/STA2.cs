using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Zero Page, X
public class STA2 : Instruction
{
    public const byte OPCODE = 0x95;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;

    public override int Call(ushort address)
    {
        STA.StoreA(address);
        return 4;
    }
}