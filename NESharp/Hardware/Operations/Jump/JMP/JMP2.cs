using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.JMP;

public class JMP2 : Instruction
{
    public const byte OPCODE = 0x6C;
	public override AddressingMode AddressingMode { get; set; } = AddressingMode.Indirect;
    
    public override int Call(ushort address)
    {
        ushort finalAddress = (ushort)(address | ((address  & 0xFF) == 0xFF ? address - 0xFF : address + 1) << 8);
        Motherboard.CPU.Registers.PC.SetValue(Motherboard.RAM.ReadShort(finalAddress));
        return 5;
    }
}