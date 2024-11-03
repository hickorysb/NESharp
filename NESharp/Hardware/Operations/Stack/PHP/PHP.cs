using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Stack.PHP;

public class PHP : Instruction
{
    public const byte OPCODE = 0x08;

    public int Call(CPU cpu)
    {
        cpu.Registers.P.SetBit(StatusBit.B, true);
        cpu.Motherboard.RAM.Push(cpu.Registers.P.BuildByte());
        cpu.Registers.P.SetBit(StatusBit.B, false);
        return 3;
    }
}