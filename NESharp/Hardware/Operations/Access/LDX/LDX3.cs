using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX - Zero Page, Y
public class LDX3 : Instruction
{
    public const byte OPCODE = 0xB6;
    
    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        LDX.LoadX(cpu, AddUShorts(zeroPageAddress, cpu.Registers.Y.GetValue()));
        return 4;
    }
}