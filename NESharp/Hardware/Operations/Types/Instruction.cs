using JetBrains.Annotations;

namespace NESharp.Hardware.Operations.Types;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers | ImplicitUseTargetFlags.WithInheritors)]
public abstract class Instruction
{
    public virtual AddressingMode AddressingMode { get; set; }
    
    public virtual int Call()
    {
        throw new NotImplementedException();
    }
    
    public virtual int Call(ushort address)
    {
        throw new NotImplementedException();
    }

    public virtual int Call(byte value)
    {
        throw new NotImplementedException();
    }
    
    public virtual int Call(AddressDetails value)
    {
        throw new NotImplementedException();
    }
}