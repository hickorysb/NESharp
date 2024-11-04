using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP - Zero Page
public class CMP2 : Instruction
{
    public const byte OPCODE = 0xC5;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        CMP.CompA(address);
        return 3;
    }
}