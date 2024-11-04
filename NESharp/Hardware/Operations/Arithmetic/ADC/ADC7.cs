using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - (Indirect, X)
public class ADC7 : Instruction
{
    public const byte OPCODE = 0x61;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectX;

    public override int Call(ushort address)
    {
        ADC.AddA(address);
        return 6;
    }
}