using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.TXS;

public class TXS : Instruction
{
    public const byte OPCODE = 0x9A;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.SP.SetValue(Motherboard.CPU.Registers.X.GetValue());
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.SP.GetValue() == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (Motherboard.CPU.Registers.SP.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}