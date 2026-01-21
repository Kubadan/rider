using System.ComponentModel.Design;

int pointA = 0;
int pointB = 0;

int gameA = 0;
int gameB = 0;

int setA = 0;
int setB = 0;


/////////////MENU
while (true)
{
    Console.WriteLine("SETY" + ":" + setA + "-" + setB);
    Console.WriteLine("HRY" + ":" + gameA + "-" + gameB);
    Console.WriteLine("BODY" + ":" + pointA + "-" + pointB);


    Console.WriteLine("Kdo získal bod? (A || B) -- HŮLKOVÉ PÍSMO!!");
    string point = Console.ReadLine();

    ///OŠETŘENÍ NEPRAVIDVÉHO INPUTU
    if (point != "A" && point != "B")
    {
        Console.WriteLine("Invalidní číslo.");
    }

    //////////PODMÍNKY PRO TEAM A
    /// BODY
    if (point == "A")
    {
        if (pointA == 0)
        {
            pointA = 15;
        }
        else if (pointA == 15)
        {
            pointA = 30;
        }
        else if (pointA == 30)
        {
            pointA = 40;
        }
        else
        {
            pointA++;
        }
    }

    ///GAMY
    if (pointA > 40)
    {
        gameA++;
        pointA = 0;
        pointB = 0;
    }

    ///SETY
    if (gameA > 5)
    {
        setA++;
        gameA = 0;
    }

    if (setA >= 2)
    {
        Console.WriteLine("VYHRÁL TEAM A");
        break;
    }


    ////////// PODMÍNKY PRO TEAM B
    if (point == "B")
    {
        if (pointB == 0)
        {
            pointB = 15;
        }
        else if (pointB == 15)
        {
            pointB = 30;
        }
        else if (pointB == 30)
        {
            pointB = 40;
        }
        else
            pointB++;

        ///GAMY
        if (pointB > 40)
        {
            gameB++;
            pointB = 0;
            pointA = 0;
        }

        ///SETY
        if (gameB > 5)
        {
            setB++;
            gameB = 0;
        }

        if (setB >= 2)
        {
            Console.WriteLine("VYHRÁL TEAM B");
            break;
        } 
    } 
}