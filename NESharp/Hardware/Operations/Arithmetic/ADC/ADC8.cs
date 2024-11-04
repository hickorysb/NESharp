using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Arithmetic.ADC;

// ADC - (Indirect), Y
public class ADC8 : Instruction
{
    public const byte OPCODE = 0x71;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.IndirectY;

    public override int Call(AddressDetails address)
    {
        ADC.AddA(address.Address);
        return address.Crosses ? 6 : 5; // CHECK FOR BOUNDARY CROSSING ("oops" cycle)
    }
}