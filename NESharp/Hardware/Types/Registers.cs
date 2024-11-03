namespace NESharp.Hardware.Types;

public class Registers()
{
    // GENERAL PURPOSE REGISTERS
    public Register8Bit A { get; private set; } = new Register8Bit();
    public Register8Bit X { get; private set; } = new Register8Bit();
    public Register8Bit Y { get; private set; } = new Register8Bit();
    
    // SPECIAL REGISTERS
    public Status P { get; private set; } = new Status(); // Status
    public Register8Bit SP { get; private set; } = new Register8Bit(); // Stack Pointer
    public Register16Bit PC { get; private set; } = new Register16Bit(); // Program Counter
}