using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL4 : Instruction
{
    public const byte OPCODE = 0x0E;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        cpu.Motherboard.RAM.WriteByte(address, ASL.ShiftLeft(cpu, address));
        return 6;
    }
}