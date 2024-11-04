using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.BRK;

public class BRK : Instruction
{
    public const byte OPCODE = 0x00;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Implied;
    
    public override int Call()
    {
        Motherboard.CPU.Registers.PC.Increment();
        Motherboard.CPU.Registers.P.SetBit(StatusBit.I, true);
        Motherboard.CPU.Registers.P.SetBit(StatusBit.B, true);
        Motherboard.RAM.PushShort(AddUShorts(Motherboard.CPU.Registers.PC.GetValue(), 1));
        Motherboard.RAM.Push(Motherboard.CPU.Registers.P.BuildByte());
        Motherboard.CPU.Registers.PC.SetValue(Motherboard.RAM.ReadShort(0xFFFE));
        Motherboard.CPU.Registers.P.SetBit(StatusBit.B, false);
        return 7;
    }
}