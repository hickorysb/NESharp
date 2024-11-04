using NESharp.Hardware.Operations.Types;
using NESharp.Hardware.Operations.Utilities;
using NESharp.Hardware.Types;

namespace NESharp.Hardware;

public class CPU : CycleBasedComponent
{
    public Registers Registers = new Registers();
    public Motherboard Motherboard;
    
    // FULL SPEED MODE
    protected override double Frequency { get; } = 0.045;
    // DEBUG SPEED MODE
    protected override double DebugFrequency { get; } = 0.005;

    private readonly Instructions instructions = new Instructions();
    private readonly Random random = new Random();
    
    public CPU(Motherboard attachedMotherboard)
    {
        Registers.SP.SetValue(255);
        Motherboard = attachedMotherboard;
    }
    
    protected override int ThreadLoop()
    {
        if(Registers.PC.GetValue() == 0x00 || Registers.PC.GetValue() == 0xFFFF){ Motherboard.Stop(); return 0; }
        byte opcode = Motherboard.RAM.ReadByte(Registers.PC.Increment());
        Motherboard.RAM.WriteByte(0xFE, (byte)random.Next(1, 16));
        return ExecuteInstruction(opcode);
    }

    private int ExecuteInstruction(byte instruction)
    {
        if (Program.DEBUG_MODE)
        {
            Console.WriteLine($"CALLING: {instructions[instruction].GetType().Name}(0x{instruction:X2}) at 0x{(Registers.PC.GetValue() - 1):X4} ADDRESSING MODE: {instructions[instruction].AddressingMode.ToString()}");
        }

        int cycles;

        switch (instructions[instruction].AddressingMode)
        {
            case AddressingMode.Immediate:
                cycles = instructions[instruction].Call(Addressing.Immediate());
                break;
            case AddressingMode.ZeroPage:
                cycles = instructions[instruction].Call(Addressing.ZeroPage());
                break;
            case AddressingMode.ZeroPageX:
                cycles = instructions[instruction].Call(Addressing.ZeroPageX());
                break;
            case AddressingMode.ZeroPageY:
                cycles = instructions[instruction].Call(Addressing.ZeroPageY());
                break;
            case AddressingMode.Absolute:
                cycles = instructions[instruction].Call(Addressing.Absolute());
                break;
            case AddressingMode.AbsoluteX:
                cycles = instructions[instruction].Call(Addressing.AbsoluteX());
                break;
            case AddressingMode.AbsoluteY:
                cycles = instructions[instruction].Call(Addressing.AbsoluteY());
                break;
            case AddressingMode.Indirect:
                cycles = instructions[instruction].Call(Addressing.Indirect());
                break;
            case AddressingMode.IndirectX:
                cycles = instructions[instruction].Call(Addressing.IndirectX());
                break;
            case AddressingMode.IndirectY:
                cycles = instructions[instruction].Call(Addressing.IndirectY());
                break;
            case AddressingMode.Implied:
                cycles = instructions[instruction].Call();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        if (Program.DEBUG_MODE)
        {
            Console.WriteLine($"CYCLES: {cycles} PC: 0x{Registers.PC.GetValue():X4} A: 0x{Registers.A.GetValue():X2} X: 0x{Registers.X.GetValue():X2} Y: 0x{Registers.Y.GetValue():X2} SP: 0x{Registers.SP.GetValue():X2} P: {Registers.P.BuildByte():b8}");
        }

        return cycles;
    }

    public void ResetState()
    {
        Registers.A.SetValue(0);
        Registers.X.SetValue(0);
        Registers.Y.SetValue(0);
        Registers.SP.SetValue(0xFD);
        Registers.P.ParseByte(0b100100);
        
        Registers.PC.SetValue(Motherboard.RAM.ReadShort(0xFFFC));
    }
}