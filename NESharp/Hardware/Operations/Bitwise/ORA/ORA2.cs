using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - Zero Page
public class ORA2 : Instruction
{
    public const byte OPCODE = 0x05;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        ORA.OrA(address);
        return 3;
    }
}