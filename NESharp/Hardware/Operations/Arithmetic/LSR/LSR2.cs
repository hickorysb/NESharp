using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.LSR;

public class LSR2 : Instruction
{
    public const byte OPCODE = 0x46;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        cpu.Motherboard.RAM.WriteByte(zeroPageAddress, LSR.ShiftRight(cpu, zeroPageAddress));
        return 5;
    }
}