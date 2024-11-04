using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Transfer.TYA;

public class TYA : Instruction
{
    public const byte OPCODE = 0x98;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.A.SetValue(Motherboard.CPU.Registers.Y.GetValue());
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.A.GetValue() == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (Motherboard.CPU.Registers.A.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}