using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - (Indirect, X)
public class ADC7 : Instruction
{
    public const byte OPCODE = 0x61;

    public int Call(CPU cpu)
    {
        byte offset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ushort address = cpu.Motherboard.RAM.ReadShort(AddUShorts(offset, cpu.Registers.X.GetValue()));
        ADC.AddA(cpu, address);
        return 6;
    }
}