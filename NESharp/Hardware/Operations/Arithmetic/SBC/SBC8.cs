using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.SBC;

// SBC - (Indirect), Y
public class SBC8 : Instruction
{
    public const byte OPCODE = 0xF1;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(offset);
        ushort finalAddress = AddUShorts(address, cpu.Registers.Y.GetValue());
        SBC.SubA(cpu, finalAddress);
        return (address & 0xFF00) != (finalAddress & 0xFF00) ? 6 : 5; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}