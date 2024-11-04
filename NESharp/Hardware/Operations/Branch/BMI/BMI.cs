using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Branch.BMI;

public class BMI : Instruction
{
    public const byte OPCODE = 0x30;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        sbyte operand = (sbyte)value;
        ushort pc = Motherboard.CPU.Registers.PC.GetValue();

        if (Motherboard.CPU.Registers.P.Negative) Motherboard.CPU.Registers.PC.Add(operand);
        return !Motherboard.CPU.Registers.P.Negative ? 2 :
            (pc & 0xFF00) != (Motherboard.CPU.Registers.PC.GetValue() & 0xFF00) ? 4 : 3;
    }
}