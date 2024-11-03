using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDA;

// LDA - Absolute
public class LDA4 : Instruction
{
    public const byte OPCODE = 0xAD;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        LDA.LoadA(cpu, address);
        return 4;
    }
}