using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STX;

// STX - Zero Page
public class STX1 : Instruction
{
    public const byte OPCODE = 0x86;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        STX.StoreX(address);
        return 3;
    }
}