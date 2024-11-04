using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Zero Page
public class LDA2 : Instruction
{
    public const byte OPCODE = 0xA5;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;
    
    public override int Call(ushort address)
    {
        LDA.LoadA(address);
        return 3;
    }
}