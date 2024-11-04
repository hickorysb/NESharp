using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.JMP;

public class JMP1 : Instruction
{
    public const byte OPCODE = 0x4C;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Absolute;
    
    public override int Call(ushort address)
    {
        Motherboard.CPU.Registers.PC.SetValue(address);
        return 3;
    }
}