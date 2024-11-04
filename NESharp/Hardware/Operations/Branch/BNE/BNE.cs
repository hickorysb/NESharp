using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Branch.BNE;

public class BNE : Instruction
{
    public const byte OPCODE = 0xD0;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;
    
    public override int Call(byte value)
    {
        sbyte operand = (sbyte)value;
        ushort pc = Motherboard.CPU.Registers.PC.GetValue();
        
        if (!Motherboard.CPU.Registers.P.Zero) Motherboard.CPU.Registers.PC.Add(operand);
        return Motherboard.CPU.Registers.P.Zero ? 2 : (pc & 0xFF00) != (Motherboard.CPU.Registers.PC.GetValue() & 0xFF00) ? 4 : 3;
    }
}