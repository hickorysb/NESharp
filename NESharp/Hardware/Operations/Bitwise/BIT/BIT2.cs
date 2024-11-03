using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.BIT;

public class BIT2 : Instruction
{
    public const byte OPCODE = 0x2C;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        BIT.BitTest(cpu, address);
        return 4;
    }
}