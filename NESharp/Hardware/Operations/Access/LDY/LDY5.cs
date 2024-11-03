using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.LDY;

// LDY Absolute, X
public class LDY5 : Instruction
{
    public const byte OPCODE = 0xBC;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, cpu.Motherboard.CPU.Registers.X.GetValue());
        LDY.LoadY(cpu, finalAddress);
        return (address & 0xFF00) != (finalAddress & 0xFF00) ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}