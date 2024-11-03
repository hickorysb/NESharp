using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.ORA;

// ORA - Absolute
public class ORA4 : Instruction
{
    public const byte OPCODE = 0x0D;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ORA.OrA(cpu, address);
        return 4;
    }
}