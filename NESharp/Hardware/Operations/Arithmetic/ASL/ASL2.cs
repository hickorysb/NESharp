using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL2 : Instruction
{
    public const byte OPCODE = 0x06;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        cpu.Motherboard.RAM.WriteByte(zeroPageAddress, ASL.ShiftLeft(cpu, zeroPageAddress));
        return 5;
    }
}