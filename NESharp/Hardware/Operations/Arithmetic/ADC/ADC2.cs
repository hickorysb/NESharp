using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - Zero Page
public class ADC2 : Instruction
{
    public const byte OPCODE = 0x65;

    public int Call(CPU cpu)
    {
        ushort zeroPageAddress = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        ADC.AddA(cpu, zeroPageAddress);
        return 3;
    }
}