namespace Game_State.Models;

public class Game
{
    public string Name { get; set; }
    public int Winner { get; set; }
    public int Dinner { get; set; }
    public double Win { get; set; }

    public Game(string name, int winner, int dinner, double win)
    {
        Name = name;
        Winner = winner;
        Dinner = dinner;
        Win = win;
    }
}
