using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Branch.BEQ;

public class BEQ : Instruction
{
    public const byte OPCODE = 0xF0;
    
    public int Call(CPU cpu)
    {
        sbyte operand = (sbyte)cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort pc = cpu.Registers.PC.GetValue();
        
        if (cpu.Registers.P.Zero) cpu.Registers.PC.Add(operand);
        return !cpu.Registers.P.Zero ? 2 : (pc & 0xFF00) != (cpu.Registers.PC.GetValue() & 0xFF00) ? 4 : 3;
    }
}