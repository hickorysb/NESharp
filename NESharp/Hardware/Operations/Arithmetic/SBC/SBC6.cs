using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - Absolute, Y
public class SBC6 : Instruction
{
    public const byte OPCODE = 0xF9;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, cpu.Motherboard.CPU.Registers.Y.GetValue());
        SBC.SubA(cpu, finalAddress);
        return (address & 0xFF00) != (finalAddress & 0xFF00) ? 5 : 4; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}