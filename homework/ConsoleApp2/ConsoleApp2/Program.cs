using System.Reflection.Emit;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
         Football task = new Football();

         task.CalculateAverageSpeed(30, 0, 20);   
         task.CalculateIfGoal(0, 70,0, 1.7);

         task.NameGen("Addidas");
         task.NameGen1("Toyota");

        }
    }
}

class Football
{
    // for first method 
    private float _Time;
    private float _RoadLenght;
    private float _XRadius;
    //for second method
    private int _BallCoordinate;
    private int _BallRadius;
    private double _GoalCoordinates;
    private double _GoalDepth;
    //NormalBall
    private int _Diameter;
    private double _Depth;
    private int _Weight;
    //YouthBall
    private int _Diameter1;
    private int _Depth1;
    private int _Weight1;
    //NameGen
    private string _ballname;
    private string _ballname1;

    public Football()
    {

        _RoadLenght = 0;
        _Time = 0;
        _XRadius = 0;
        _BallCoordinate = 30;
        _GoalCoordinates = 0;
        //NormalBall
        _Diameter = 0;
        _Depth = 1.7;
        _Weight = 0;
        _ballname = ("Addidas");
        //youthball
        _Diameter1 = 0;
        _Depth1 = 0;
        _Weight1 = 0;
        _ballname1 = ("Toyota");

    }
    public Football(float XRadius, float RoadLenght, float Time, int BallCord, double GoalCord, double GoalDep, int Diameter, double Depth, int Weight, int Diameter1, int Depth1, int Weight1, string ballname, string ballname1)
    {

        this._Time = Time;
        this._RoadLenght = RoadLenght;
        this._XRadius = XRadius;
        this._BallCoordinate = BallCord;
        this._GoalCoordinates = GoalCord;
        this._GoalDepth = GoalDep;
        //NormalBall
        this._Diameter = Diameter;
        this._Depth = Depth;
        this._Weight = Weight;
        this._ballname = ballname;
        //YouthBall
        this._Diameter1 = Diameter1;
        this._Depth1 = Depth1;
        this._Weight1 = Weight1;
        this._ballname1 = ballname1;


    }
    public void CalculateAverageSpeed(float XRadius, float RoadLenght, float Time)
    {

        float result = Math.Abs((XRadius - RoadLenght) / Time);
        Console.WriteLine(result);

    }
    public void CalculateIfGoal(int BallCord, double GoalCord, int Diameter, double GoalDep)
    {

        double ballRadius = Diameter / 2;
        GoalCord = 0;
        double result1 = GoalCord - GoalDep;
                                                                        
        Console.WriteLine(BallCord - ballRadius >= GoalCord - GoalDep);

    }
    public void NameGen(string ballname)
    {
        Random random = new Random();
        int randomNumber =
            random.Next(10000, 100000);
       
        string one = ballname.Substring(0,4);
        Console.WriteLine(one + randomNumber );

 
    }
    public void NameGen1(string ballname1)
    {
        Random random = new Random();
        int randomNumber =
            random.Next(100, 1000);

        string one = ballname1.Substring(0, 3);
        Console.WriteLine(one + randomNumber);


    }
}
