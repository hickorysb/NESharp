using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Compare.CMP;

// CMP - Absolute, Y
public class CMP6 : Instruction
{
    public const byte OPCODE = 0xD9;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, cpu.Motherboard.CPU.Registers.Y.GetValue());
        CMP.CompA(cpu, finalAddress);
        return (address & 0xFF00) != (finalAddress & 0xFF00) ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}