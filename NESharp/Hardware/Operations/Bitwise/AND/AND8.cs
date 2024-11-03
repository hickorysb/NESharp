using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - (Indirect), Y
public class AND8 : Instruction
{
    public const byte OPCODE = 0x31;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(offset);
        ushort finalAddress = AddUShorts(address, cpu.Registers.Y.GetValue());
        AND.AndMem(cpu, finalAddress);
        return (address & 0xFF00) != (finalAddress & 0xFF00) ? 6 : 5; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}