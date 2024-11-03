using JetBrains.Annotations;

namespace NESharp.Hardware.Types;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers | ImplicitUseTargetFlags.WithInheritors)]
public interface Instruction
{
    public int Call(CPU cpu);
}