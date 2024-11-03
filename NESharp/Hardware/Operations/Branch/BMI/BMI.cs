using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Branch.BMI;

public class BMI : Instruction
{
    public const byte OPCODE = 0x30;
    
    public int Call(CPU cpu)
    {
        sbyte operand = (sbyte)cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort pc = cpu.Registers.PC.GetValue();
        
        if (cpu.Registers.P.Negative) cpu.Registers.PC.Add(operand);
        return !cpu.Registers.P.Negative ? 2 : (pc & 0xFF00) != (cpu.Registers.PC.GetValue() & 0xFF00) ? 4 : 3;
    }
}