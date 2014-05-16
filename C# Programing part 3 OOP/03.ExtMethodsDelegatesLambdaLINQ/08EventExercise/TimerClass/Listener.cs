using System;

public class Listener
{
    public void Subscribe(Timer m)
    {
        m.Tick += new Timer.TickHandler(TelerikLogo);
    }
    private void TelerikLogo(Timer m, EventArgs e)
    {
        Console.WriteLine("..***...***.");
        Console.WriteLine(".**.**.**.**");
        Console.WriteLine(".....**.....");
        Console.WriteLine("...**..**...");
        Console.WriteLine("..**....**..");
        Console.WriteLine("...**..**...");
        Console.WriteLine(".....**.....");
        Console.WriteLine();
    }
}

