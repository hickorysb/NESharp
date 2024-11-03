using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Branch.BNE;

public class BNE : Instruction
{
    public const byte OPCODE = 0xD0;
    
    public int Call(CPU cpu)
    {
        sbyte operand = (sbyte)cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort pc = cpu.Registers.PC.GetValue();
        
        if (!cpu.Registers.P.Zero) cpu.Registers.PC.Add(operand);
        return cpu.Registers.P.Zero ? 2 : (pc & 0xFF00) != (cpu.Registers.PC.GetValue() & 0xFF00) ? 4 : 3;
    }
}