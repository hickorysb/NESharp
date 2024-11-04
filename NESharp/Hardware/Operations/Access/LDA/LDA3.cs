using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Zero Page, X
public class LDA3 : Instruction
{
    public const byte OPCODE = 0xB5;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;
    
    public override int Call(ushort address)
    {
        LDA.LoadA(address);
        return 4;
    }
}