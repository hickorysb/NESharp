using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.BRK;

public class BRK : Instruction
{
    public const byte OPCODE = 0x00;
    
    public int Call(CPU cpu)
    {
        cpu.Registers.PC.Increment();
        cpu.Registers.P.SetBit(StatusBit.I, true);
        cpu.Registers.P.SetBit(StatusBit.B, true);
        cpu.Motherboard.RAM.PushShort(AddUShorts(cpu.Registers.PC.GetValue(), 1));
        cpu.Motherboard.RAM.Push(cpu.Registers.P.BuildByte());
        cpu.Registers.PC.SetValue(cpu.Motherboard.RAM.ReadShort(0xFFFE));
        cpu.Registers.P.SetBit(StatusBit.B, false);
        return 7;
    }
}