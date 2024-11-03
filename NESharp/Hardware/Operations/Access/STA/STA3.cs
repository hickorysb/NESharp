using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Absolute
public class STA3 : Instruction
{
    public const byte OPCODE = 0x8D;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        STA.StoreA(cpu, address);
        return 4;
    }
}