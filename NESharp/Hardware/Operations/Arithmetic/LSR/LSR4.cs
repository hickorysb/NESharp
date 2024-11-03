using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR4 : Instruction
{
    public const byte OPCODE = 0x4E;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        cpu.Motherboard.RAM.WriteByte(address, LSR.ShiftRight(cpu, address));
        return 6;
    }
}