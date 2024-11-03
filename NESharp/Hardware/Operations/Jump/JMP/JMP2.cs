using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Jump.JMP;

public class JMP2 : Instruction
{
    public const byte OPCODE = 0x6C;
    
    public int Call(CPU cpu)
    {
        ushort offset = cpu.Motherboard.RAM.ReadShort(cpu.Registers.PC.Increment(2));
        ushort address = (ushort)(offset | ((offset  & 0xFF) == 0xFF ? offset - 0xFF : offset + 1) << 8);
        cpu.Registers.PC.SetValue(cpu.Motherboard.RAM.ReadShort(address));
        return 5;
    }
}