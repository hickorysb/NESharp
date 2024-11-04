using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - Zero Page
public class ADC2 : Instruction
{
    public const byte OPCODE = 0x65;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPage;

    public override int Call(ushort address)
    {
        ADC.AddA(address);
        return 3;
    }
}