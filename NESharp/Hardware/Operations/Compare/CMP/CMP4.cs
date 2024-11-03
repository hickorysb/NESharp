using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP - Absolute
public class CMP4 : Instruction
{
    public const byte OPCODE = 0xCD;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        CMP.CompA(cpu, address);
        return 4;
    }
}