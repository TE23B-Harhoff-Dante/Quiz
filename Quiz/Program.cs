

using System.Threading.Tasks.Dataflow;

int score = 0;

string choice = "";
string choice1 = "";
string choice2 = "";


Console.WriteLine("Vilken snabbmat plats är best?\n");
Console.WriteLine(" A) McDonalds B) MAX C) BurgerKing");




choice = Console.ReadLine();

if (choice.ToLower() == "b" || choice.ToLower() == "max")
{

    score++;

    Console.WriteLine("CORRECT");
}

else

{
    Console.WriteLine("WRONG");
}

Console.WriteLine("Vilket är det bästa landet i Scandinavien?\n");
Console.WriteLine("A) Sverige B) Norge C) Danmark");

choice1 = Console.ReadLine();

if (choice1.ToLower() == "a")
{
    score++;
    Console.WriteLine("CORRECT");

}
else if (choice1.ToLower() == "c")
{
    Console.WriteLine("ÄR DU GALEN????");
}

else
{

    Console.Write("WRONG");
}

Console.WriteLine("Vilket är det största djuret i världen?\n");
Console.WriteLine("A) blåvalen B) mus C) myra");

choice2 = Console.ReadLine();




