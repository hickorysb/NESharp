using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - Immediate
public class ADC1 : Instruction
{
    public const byte OPCODE = 0x69;

    public int Call(CPU cpu)
    {
        byte operand = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ADC.AddA(cpu, operand);
        return 2;
    }
}