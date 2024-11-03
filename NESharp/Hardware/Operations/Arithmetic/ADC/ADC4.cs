using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - Absolute
public class ADC4 : Instruction
{
    public const byte OPCODE = 0x6D;

    public int Call(CPU cpu)
    {
        ushort address = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ADC.AddA(cpu, address);
        return 4;
    }
}