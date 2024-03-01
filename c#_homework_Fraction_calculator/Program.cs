// See https://aka.ms/new-console-template for more information


//// taks 1 point class

//Point p = new Point(2, 3);
//p.ShowData();

//class Point
//{
//    public int x; 
//    public int y;

//    public Point()
//    {
//        this.x=0; 
//        this.y=0;
//    }

//    public Point(int x, int y)
//    {
//        this.x = x;
//        this.y = y;
//    }

//    public void ShowData()
//    {
//        Console.WriteLine($" X : {this.x}");
//        Console.WriteLine($" Y : {this.y}");
//    }
//}



/////////////////////////////////////////////////////////////////



////task2 counter

//Counter c = new Counter(1,100,50);
//c.Increment();
//c.getCurrent();

//class Counter
//{
//    public int min { get; set; }
//    public int max { get; set; }
//    public int currentData { get; set; }

//    public Counter()
//    {
//        this.min = 0;
//        this.max = 0;
//        this.currentData = 0;
//    }
//    public Counter(int min,int max)
//    {
//        this.min= min;
//        this.max = max;
//    }
//    public Counter(int min,int max,int currentData)
//    {
//        this.min = min;
//        this.max = max;
//        this.currentData = currentData;
//    }
//    public void getCurrent()
//    {
//        Console.WriteLine($" Data : {this.currentData}");
//    }
//    public void Increment()
//    {
//        if (this.currentData == 100)
//        {
//            this.currentData = 0;
//        }
//        else
//        {
//            this.currentData++;
//        }
//    }

//}




////////////////////////////////////////////////////////////////////



//task3 Fraction


calculator_First_Page();
void calculator_First_Page()
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\tKesr Hesablayici\t\t\t\n\n\n");
    Console.WriteLine(" [1] Toplama ");
    Console.WriteLine(" [2] Cixma ");
    Console.WriteLine(" [3] Vurma ");
    Console.WriteLine(" [4] Bolme ");
    Console.WriteLine();
    Console.Write(" Seciminizi daxil edin : ");
    string first_page_choice = Console.ReadLine();
    calculator_Second_page(first_page_choice);
}

void calculator_Second_page(string first_page_choice)
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\tKesr Hesablayici\t\t\t\n\n\n");
    Console.WriteLine(" Ilk kesri daxil edin : ");
    string firstFractionsUP = Console.ReadLine();
    Console.WriteLine("-----");
    string firstFractionsDOWN = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine(" Ikinci kesri daxil edin : ");
    string secondFractionsUP = Console.ReadLine();
    Console.WriteLine("-----");
    string secondFractionsDOWN = Console.ReadLine();
    if (first_page_choice == "1")
    {
        Toplama(firstFractionsUP, firstFractionsDOWN, secondFractionsUP, secondFractionsDOWN);
    }
    else if (first_page_choice == "2")
    {
        Cixma(firstFractionsUP, firstFractionsDOWN, secondFractionsUP, secondFractionsDOWN);
    }
    else if (first_page_choice == "3")
    {
        Vurma(firstFractionsUP, firstFractionsDOWN, secondFractionsUP, secondFractionsDOWN);
    }
    else if (first_page_choice == "4")
    {
        Bolme(firstFractionsUP, firstFractionsDOWN, secondFractionsUP, secondFractionsDOWN);
    }
}

void Toplama(string firstFractionsUP, string firstFractionsdown, string secondFractionsUP, string secondFractionsDOWN)
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\tKesr Hesablayici\t\t\t\n\n\n");

    int f_up = int.Parse(firstFractionsUP);
    int f_down = int.Parse(firstFractionsdown);
    int s_up = int.Parse(secondFractionsUP);
    int s_down = int.Parse(secondFractionsDOWN);

    int final_down = s_down * f_down;
    int final_up = ((f_up * s_down) + (s_up * f_down));

    Console.WriteLine($" {final_up}");
    Console.WriteLine(" -----");
    Console.WriteLine($" {final_down}");
}

void Cixma(string firstFractionsUP, string firstFractionsdown, string secondFractionsUP, string secondFractionsDOWN)
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\tKesr Hesablayici\t\t\t\n\n\n");

    int f_up = int.Parse(firstFractionsUP);
    int f_down = int.Parse(firstFractionsdown);
    int s_up = int.Parse(secondFractionsUP);
    int s_down = int.Parse(secondFractionsDOWN);

    int final_down = s_down * f_down;
    int final_up = ((f_up * s_down) - (s_up * f_down));

    Console.WriteLine($" {final_up}");
    Console.WriteLine(" -----");
    Console.WriteLine($" {final_down}");
}

void Vurma(string firstFractionsUP, string firstFractionsdown, string secondFractionsUP, string secondFractionsDOWN)
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\tKesr Hesablayici\t\t\t\n\n\n");

    int f_up = int.Parse(firstFractionsUP);
    int f_down = int.Parse(firstFractionsdown);
    int s_up = int.Parse(secondFractionsUP);
    int s_down = int.Parse(secondFractionsDOWN);

    int final_down = s_down * f_down;
    int final_up = f_up * s_up;

    Console.WriteLine($" {final_up}");
    Console.WriteLine(" -----");
    Console.WriteLine($" {final_down}");
}

void Bolme(string firstFractionsUP, string firstFractionsdown, string secondFractionsUP, string secondFractionsDOWN)
{
    Console.Clear();
    Console.WriteLine("\n\n\n\t\t\tKesr Hesablayici\t\t\t\n\n\n");

    int f_up = int.Parse(firstFractionsUP);
    int f_down = int.Parse(firstFractionsdown);
    int s_up = int.Parse(secondFractionsUP);
    int s_down = int.Parse(secondFractionsDOWN);

    int final_down = s_down * f_down;
    int final_up = f_up * s_up;

    Console.WriteLine($" {final_down}");
    Console.WriteLine(" -----");
    Console.WriteLine($" {final_up}");
}
