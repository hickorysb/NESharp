using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.DEY;

public class DEY : Instruction
{
    public const byte OPCODE = 0x88;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.Y.Decrement();
        Motherboard.CPU.Registers.P.SetBit(StatusBit.Z, Motherboard.CPU.Registers.Y.GetValue() == 0);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.N, (Motherboard.CPU.Registers.Y.GetValue() & 0b1000_0000) != 0);
        return 2;
    }
}