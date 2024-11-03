using System.Reflection;
using NESharp.Hardware.Operations.Other.NOP;
using NESharp.Hardware.Types;

namespace NESharp.Hardware;

public class Instructions
{
    public Instruction this[byte index] => instructions[index];

    private readonly Instruction[] instructions = new Instruction[256];

    public Instructions()
    {
        int count = 0;
        int warnings = 0;
        
        foreach (Type type in Assembly.GetCallingAssembly().GetTypes().Where(t => t.IsAssignableTo(typeof(Instruction)) && !t.IsAbstract))
        {
            Instruction? newInstruction = (Instruction?)Activator.CreateInstance(type);
            if (newInstruction == null) throw new Exception($"Cannot instantiate instruction {type.FullName}");
            FieldInfo? opcodeF = type.GetField("OPCODE", BindingFlags.Static | BindingFlags.Public);
            if (opcodeF == null) throw new Exception($"Opcode missing for {type.FullName}");
            byte? opcode = (byte?)opcodeF.GetValue(null);
            if (opcode == null) throw new Exception($"Invalid opcode for {type.FullName}");
            // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
            if (instructions[opcode.Value] != null)
            {
                Console.WriteLine($"Warning: multiple instructions for opcode {opcode.Value} when processing {type.FullName}, existing instruction is: {instructions[opcode.Value].GetType().FullName}");
                warnings++;
            }
            instructions[opcode.Value] = newInstruction;
            
            if (Program.DEBUG_MODE)
            {
                Console.WriteLine($"REGISTERED INSTRUCTION: {type.FullName}, OPCODE: 0x{opcode:X2}");
            }

            count++;
        }

        for (int i = 0; i < 256; i++)
        {
            // ReSharper disable once NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
            instructions[i] ??= new NOP();
        }
        
        if (Program.DEBUG_MODE) Console.WriteLine($"INSTRUCTIONS: {count}");
        
        if (warnings > 0) Console.WriteLine($"WARNINGS: {warnings}");
    }
}