using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPY;

// CPY - Absolute
public class CPY3 : Instruction
{
    public const byte OPCODE = 0xCC;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        CPY.CompY(cpu, address);
        return 4;
    }
}