namespace Latihan12;

public class ShooterGame : Game
{
    public int timer;

    public void setTimer(int timer)
    {
        this.timer = timer;
    }

    public void setBaseTimer(int timer)
    {
        base.timer = timer;
    }

    public int getTimer()
    {
        return this.timer;
    }

    public int getBaseTimer()
    {
        return base.timer;
    }
}