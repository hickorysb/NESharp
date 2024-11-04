using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPX;

// CPX - Zero Page
public class CPX2 : Instruction
{
    public const byte OPCODE = 0xE4;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        CPX.CompX(address);
        return 3;
    }
}