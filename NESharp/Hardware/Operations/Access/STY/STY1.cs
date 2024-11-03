using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STY;

// STY - Zero Page
public class STY1 : Instruction
{
    public const byte OPCODE = 0x84;

    public int Call(CPU cpu)
    {
        ushort zeroPageOffset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        STY.StoreY(cpu, zeroPageOffset);
        return 3;
    }
}