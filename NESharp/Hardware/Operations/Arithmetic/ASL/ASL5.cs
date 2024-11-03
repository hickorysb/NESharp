using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ASL;

public class ASL5 : Instruction
{
    public const byte OPCODE = 0x1E;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, cpu.Registers.X.GetValue());
        cpu.Motherboard.RAM.WriteByte(finalAddress, ASL.ShiftLeft(cpu, finalAddress));
        return 7;
    }
}