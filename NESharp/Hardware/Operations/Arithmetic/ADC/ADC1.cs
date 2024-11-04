using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - Immediate
public class ADC1 : Instruction
{
    public const byte OPCODE = 0x69;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Immediate;

    public override int Call(byte value)
    {
        ADC.AddA(value);
        return 2;
    }
}