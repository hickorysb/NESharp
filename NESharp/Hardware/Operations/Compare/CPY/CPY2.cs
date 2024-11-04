using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPY;

// CPY - Zero Page
public class CPY2 : Instruction
{
    public const byte OPCODE = 0xC4;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        CPY.CompY(address);
        return 3;
    }
}