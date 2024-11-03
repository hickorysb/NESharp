using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CPX;

// CPX - Absolute
public class CPX3 : Instruction
{
    public const byte OPCODE = 0xEC;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        CPX.CompX(cpu, address);
        return 4;
    }
}