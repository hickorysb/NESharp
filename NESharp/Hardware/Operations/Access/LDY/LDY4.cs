using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY - Absolute
public class LDY4 : Instruction
{
    public const byte OPCODE = 0xAC;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        LDY.LoadY(cpu, address);
        return 4;
    }
}