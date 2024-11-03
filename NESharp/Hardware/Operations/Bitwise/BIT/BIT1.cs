using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.BIT;

public class BIT1 : Instruction
{
    public const byte OPCODE = 0x24;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        BIT.BitTest(cpu, zeroPageAddress);
        return 3;
    }
}