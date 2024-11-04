using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - Zero Page, X
public class ORA3 : Instruction
{
    public const byte OPCODE = 0x15;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;
    
    public override int Call(ushort address)
    {
        ORA.OrA(address);
        return 4;
    }
}