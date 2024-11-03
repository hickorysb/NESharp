using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ROL;

public class ROL2 : Instruction
{
    public const byte OPCODE = 0x26;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        cpu.Motherboard.RAM.WriteByte(zeroPageAddress, ROL.RotateLeft(cpu, zeroPageAddress));
        return 5;
    }
}