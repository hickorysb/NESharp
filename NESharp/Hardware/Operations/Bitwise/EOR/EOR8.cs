using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.EOR;

// EOR - (Indirect), Y
public class EOR8 : Instruction
{
    public const byte OPCODE = 0x51;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(offset);
        ushort finalAddress = AddUShorts(address, cpu.Registers.Y.GetValue());
        EOR.XorA(cpu, finalAddress);
        return (address & 0xFF00) != (finalAddress & 0xFF00) ? 6 : 5; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}