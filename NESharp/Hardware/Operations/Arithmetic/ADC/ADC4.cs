using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - Absolute
public class ADC4 : Instruction
{
    public const byte OPCODE = 0x6D;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;

    public override int Call(ushort address)
    {
        ADC.AddA(address);
        return 4;
    }
}