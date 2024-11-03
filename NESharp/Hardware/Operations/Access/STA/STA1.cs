using NESharp.Hardware.Types;

namespace NESharp.Hardware.Operations.Access.STA;

// STA - Zero Page
public class STA1 : Instruction
{
    public const byte OPCODE = 0x85;

    public int Call(CPU cpu)
    {
        ushort zeroPageOffset = cpu.Motherboard.RAM.ReadByte(cpu.Registers.PC.Increment());
        STA.StoreA(cpu, zeroPageOffset);
        return 3;
    }
}