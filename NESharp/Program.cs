global using static NESharp.Utilities.CPUMath;
using NESharp.Hardware;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace NESharp;

public static class Program
{
    public const bool DEBUG_MODE = true;

    private static Hardware.Motherboard motherboard = null!;
    
    public static void Main(string[] args)
    {
        RenderWindow win = new RenderWindow(new VideoMode(512, 512), "NESharp", Styles.Close);

        RectangleShape[] matrix = new RectangleShape[1024];

        for(int i = 0; i < 1024; i++)
        {
            matrix[i] = new RectangleShape();
            matrix[i].Size = new Vector2f(16, 16);
            matrix[i].Position = new Vector2f((i % 32f) * 16, MathF.Floor(i / 32f) * 16);
            matrix[i].FillColor = new Color((byte)((i % 32f) * 16), (byte)(MathF.Floor(i / 32f) * 16),
                (byte)((byte)((i % 32f) * 16) + (byte)(MathF.Floor(i / 32f) * 16)));
        }
        
        motherboard = new Hardware.Motherboard();
        
        win.Closed += (_, _) =>
        {
            win.Close();
            motherboard.Stop();
        };
        
        win.SetFramerateLimit(60);

        win.KeyPressed += (_, key) =>
        {
            if (DEBUG_MODE && key.Code == Keyboard.Key.Space) Motherboard.CPU.Resume();
            if (key.Code == Keyboard.Key.W) Motherboard.RAM.WriteByte(0xFF, 0x77);
            if (key.Code == Keyboard.Key.S) Motherboard.RAM.WriteByte(0xFF, 0x73);
            if (key.Code == Keyboard.Key.A) Motherboard.RAM.WriteByte(0xFF, 0x61);
            if (key.Code == Keyboard.Key.D) Motherboard.RAM.WriteByte(0xFF, 0x64);
        };
        
        while (win.IsOpen)
        {
            win.DispatchEvents();

            Span<byte> screenbuf = Motherboard.RAM.GetScreenMemory();
            
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i].FillColor = screenbuf[i] switch
                {
                    0 => Color.Black,
                    1 => Color.White,
                    2 or 9 => new Color(56, 56, 56),
                    3 or 10 => Color.Red,
                    4 or 11 => Color.Green,
                    5 or 12 => Color.Blue,
                    6 or 13 => Color.Magenta,
                    7 or 14 => Color.Yellow,
                    _ => Color.Cyan
                };
                win.Draw(matrix[i]);
            }

            // Finally, display the rendered frame on screen
            win.Display();
        }
    }
}