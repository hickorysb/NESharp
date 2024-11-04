using NESharp.Hardware.Operations.Types;

namespace NESharp.Hardware.Operations.Utilities;

public static class Addressing
{
    public static byte Immediate()
    {
        return Motherboard.RAM.ReadByte(Motherboard.CPU.Registers.PC.Increment());
    }
    
    public static ushort ZeroPage()
    {
        return Motherboard.RAM.ReadByte(Motherboard.CPU.Registers.PC.Increment());
    }

    public static ushort ZeroPageX()
    {
        return AddUShorts(Motherboard.RAM.ReadByte(Motherboard.CPU.Registers.PC.Increment()), Motherboard.CPU.Registers.X.GetValue());
    }
    
    public static ushort ZeroPageY()
    {
        return AddUShorts(Motherboard.RAM.ReadByte(Motherboard.CPU.Registers.PC.Increment()), Motherboard.CPU.Registers.Y.GetValue());
    }
    
    public static ushort Absolute()
    {
        return Motherboard.RAM.ReadShort(Motherboard.CPU.Registers.PC.Increment(2));
    }
    
    public static AddressDetails AbsoluteX()
    {
        ushort address = Motherboard.RAM.ReadShort(Motherboard.CPU.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, Motherboard.CPU.Registers.X.GetValue());
        return new AddressDetails(finalAddress, (address & 0xFF00) != (finalAddress & 0xFF00));
    }
    
    public static AddressDetails AbsoluteY()
    {
        ushort address = Motherboard.RAM.ReadShort(Motherboard.CPU.Registers.PC.Increment(2));
        ushort finalAddress = AddUShorts(address, Motherboard.CPU.Registers.Y.GetValue());
        return new AddressDetails(finalAddress, (address & 0xFF00) != (finalAddress & 0xFF00));
    }
    
    public static ushort Indirect()
    {
        return Motherboard.RAM.ReadShort(Motherboard.CPU.Registers.PC.Increment(2));
    }

    public static ushort IndirectX()
    {
        byte offset = Motherboard.RAM.ReadByte(Motherboard.CPU.Registers.PC.Increment());
        ushort address = Motherboard.RAM.ReadShort(AddUShorts(offset, Motherboard.CPU.Registers.X.GetValue()));
        return address;
    }
    
    public static AddressDetails IndirectY()
    {
        byte offset = Motherboard.RAM.ReadByte(Motherboard.CPU.Registers.PC.Increment());
        ushort address = Motherboard.RAM.ReadShort(offset);
        ushort finalAddress = AddUShorts(address, Motherboard.CPU.Registers.Y.GetValue());
        return new AddressDetails(finalAddress, (address & 0xFF00) != (finalAddress & 0xFF00));
    }
}