using System;

public class Timer
{
    public event TickHandler Tick;
    private const int ThickInterval = 3000;
    public EventArgs e = null; 
    public delegate void TickHandler(Timer m, EventArgs e);
    public void Start()
    {
        while (true)
        {
            System.Threading.Thread.Sleep(ThickInterval);
            if (Tick != null)
            {
                Tick(this, e);
            }
        }
    }
}
