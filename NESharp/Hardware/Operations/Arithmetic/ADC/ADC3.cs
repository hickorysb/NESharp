using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - Zero Page, X
public class ADC3 : Instruction
{
    public const byte OPCODE = 0x75;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.ZeroPageX;

    public override int Call(ushort address)
    {
        ADC.AddA(address);
        return 4;
    }
}