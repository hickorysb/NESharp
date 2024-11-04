using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Zero Page
public class STA1 : Instruction
{
    public const byte OPCODE = 0x85;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        STA.StoreA(address);
        return 3;
    }
}