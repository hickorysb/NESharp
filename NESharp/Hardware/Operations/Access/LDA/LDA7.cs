using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - (Indirect, X)
public class LDA7 : Instruction
{
    public const byte OPCODE = 0xA1;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(AddUShorts(offset, cpu.Registers.X.GetValue()));
        LDA.LoadA(cpu, address);
        return 6;
    }
}