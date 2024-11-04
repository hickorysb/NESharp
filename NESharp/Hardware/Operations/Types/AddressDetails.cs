namespace NESharp.Hardware.Operations.Types;

public struct AddressDetails(ushort address, bool cross)
{
    public ushort Address = address;
    public bool Crosses = cross;
}