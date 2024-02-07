// See https://aka.ms/new-console-template for more information
Console.WriteLine("C# console app GAMING");
string[] game = { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
string input;
Console.WriteLine("Controls are \n" + " 1 | 2 | 3 " + "\n---+---+---" + "\n4 | 5 | 6" + "\n---+---+---" + "\n7 | 8 | 9");
while (true) 
{
    while (true) {
        Console.WriteLine("                  X's turn");
        input = Console.ReadLine();
        try { int.Parse(input); }
        catch { Console.WriteLine("BRUH THE CONTROLS ARE RIGHT THERE YOU KNOW HOW TO PLAY TIK TAC TOE"); continue; }
        int checker = Check(Int32.Parse(input), game);
        if (checker == 0)
        {
            continue;
        }
        if (checker == 1) 
        { break; }        
    }
    
    game[Int32.Parse(input) ] = "X";
    Update(game);
    GameCheckState(game);
    while (true)
    {
        Console.WriteLine("                  O's turn");
        input = Console.ReadLine();
        try { int.Parse(input); }
        catch { Console.WriteLine("BRUH THE CONTROLS ARE RIGHT THERE YOU KNOW HOW TO PLAY TIK TAC TOE"); continue; }
        int checker = Check(Int32.Parse(input), game);
        if (checker == 0)
        {
            continue;
        }
        if (checker == 1)
        { break; }
    }
    game[Int32.Parse(input)] = "O";
    Update(game);
    GameCheckState(game);
}
static void drawWinner(string winner) { 
    int counter = 0;
    string yourMOM = "#";
    while (true) 
    { Console.WriteLine(yourMOM);
        yourMOM = yourMOM + "#" + winner+" WON";
        counter++;
        if (counter == 20)
        {
            break;
        }
    }
    Environment.Exit(0);
    return;
}
static void GameCheckState(string[] game)
{
    // CHECKS IF BOARD IS FULL
    int counter =0;
    foreach (string i in game)
    {
        if (i == "O" | i =="X")
        {
            counter++;
        }
        
    }
    if (counter == 9) {
        Console.WriteLine("GameOver!");
        
        counter = 0;
    }
    //CHECKS DIAGONAL
    if (game[1]== game[5]&& game[9] == game[1] && game[1]!= " ")
    {
        Console.WriteLine("              \n\n\n  #####GameOver!" + game[1]+ " Won the game!########\n\n\n\n\n\n");
        drawWinner(game[1]);
    }
    if (game[3] == game[5] && game[7] == game[3] && game[3] != " ")
    {
        Console.WriteLine("              \n\n\n  #####GameOver!" + game[3] + " Won the game!########\n\n\n\n\n\n");
        drawWinner(game[3]);
    }
    //THE LEFT TO RIGHT
    if (game[1] == game[2] && game[3] == game[1] && game[1] != " ")
    {
        Console.WriteLine("              \n\n\n  #####GameOver!" + game[1] + " Won the game!########\n\n\n\n\n\n");
        drawWinner(game[1]);
    }
    if (game[4] == game[5] && game[6] == game[4] && game[4] != " ")
    {
        Console.WriteLine("              \n\n\n  #####GameOver!" + game[4] + " Won the game!########\n\n\n\n\n\n");
        drawWinner(game[4]);
    }
    if (game[7] == game[8] && game[9] == game[7] && game[7] != " ")
    {
        Console.WriteLine("              \n\n\n  #####GameOver!" + game[7] + " Won the game!########\n\n\n\n\n\n");
        drawWinner(game[7]);
    }
    //UP TO DOWN
    if (game[1] == game[4] && game[7] == game[4] && game[1] != " ")
    {
        Console.WriteLine("              \n\n\n  #####GameOver!" + game[1] + " Won the game!########\n\n\n\n\n\n");
        drawWinner(game[1]);
    }
    if (game[2] == game[5] && game[5] == game[8] && game[2] != " ")
    {
        Console.WriteLine("              \n\n\n  #####GameOver!" + game[2] + " Won the game!########\n\n\n\n\n\n");
        drawWinner(game[2]);
    }
    if (game[3] == game[6] && game[6] == game[9] && game[3] != " ")
    {
        Console.WriteLine("              \n\n\n  #####GameOver!" + game[3] + " Won the game!########\n\n\n\n\n\n");
        drawWinner(game[3]);
    }
    return;
}
    
static void Update(string [] game)
{

    Console.WriteLine(game[1] +"  |  "+ game[2]+ "  |  "+ game[3]);
    Console.WriteLine("---+---+---");
    Console.WriteLine(game[4]+ "  |  "+ game[5]+ "  |  "+ game[6]);
    Console.WriteLine("---+---+---");
    Console.WriteLine(game[7]+ "  |  "+ game[8]+ "  |  "+ game[9]);
}
static int Check(int input, string[] game)
{
    if (input <= 0 | input >= 10 | game[input] =="X" | game[input] == "O")
    {
        Console.WriteLine("Out of bounds! Please put a correct possible option! ");
        return 0;
    }
    else { return 1; }
}