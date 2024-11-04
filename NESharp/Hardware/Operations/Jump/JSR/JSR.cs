using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.JSR;

public class JSR : Instruction
{
    public const byte OPCODE = 0x20;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;
    
    public override int Call(ushort address)
    {
        Motherboard.RAM.PushShort(SubUShorts(Motherboard.CPU.Registers.PC.GetValue(), 1));
        Motherboard.CPU.Registers.PC.SetValue(address);
        return 6;
    }
}