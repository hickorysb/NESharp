using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Bitwise.AND;

// AND - Absolute, X
public class AND5 : Instruction
{
    public const byte OPCODE = 0x3D;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, cpu.Motherboard.CPU.Registers.X.GetValue());
        AND.AndMem(cpu, finalAddress);
        return (address & 0xFF00) != (finalAddress & 0xFF00) ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}