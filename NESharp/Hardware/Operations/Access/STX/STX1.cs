using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STX;

// STX - Zero Page
public class STX1 : Instruction
{
    public const byte OPCODE = 0x86;

    public int Call(CPU cpu)
    {
        ushort zeroPageOffset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        STX.StoreX(cpu, zeroPageOffset);
        return 3;
    }
}