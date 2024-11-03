using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY - Zero Page, X
public class LDY3 : Instruction
{
    public const byte OPCODE = 0xB4;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDY.LoadY(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 4;
    }
}