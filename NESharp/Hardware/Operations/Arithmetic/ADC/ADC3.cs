using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - Zero Page, X
public class ADC3 : Instruction
{
    public const byte OPCODE = 0x75;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ADC.AddA(cpu, AddUShorts(zeroPageAddress, cpu.Registers.X.GetValue()));
        return 4;
    }
}