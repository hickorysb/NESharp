using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Transfer.TAX;

public class TAX : Instruction
{
    public const byte OPCODE = 0xAA;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.X.SetValue(Motherboard.CPU.Registers.A.GetValue());
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.X.GetValue() == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (Motherboard.CPU.Registers.X.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}