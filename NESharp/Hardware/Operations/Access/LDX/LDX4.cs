using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDX;

// LDX - Absolute
public class LDX4 : Instruction
{
    public const byte OPCODE = 0xAE;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        LDX.LoadX(cpu, address);
        return 4;
    }
}