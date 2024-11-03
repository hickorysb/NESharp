using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL4 : Instruction
{
    public const byte OPCODE = 0x2E;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        cpu.Motherboard.RAM.WriteByte(address, ROL.RotateLeft(cpu, address));
        return 6;
    }
}