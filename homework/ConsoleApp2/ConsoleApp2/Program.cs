namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
         Football task = new Football();

         task.CalculateAverageSpeed(30, 0, 20);
            task.CalculateIfGoal(40, 20, 70, 1.7);

          














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
    private int _GoalCoordinates;
    private double _GoalDepth;
    //NormalBall
    private int _Diameter;
    private double _Depth;
    private int _Weight;
    //YouthBall
    private int _Diameter1;
    private int _Depth1;
    private int _Weight1;

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
        //youthball
        _Diameter1 = 0;
        _Depth1 = 0;
        _Weight1 = 0;

    }
    public Football(float XRadius, float RoadLenght, float Time, int BallCord, int GoalCord, double GoalDep, int Diameter, double Depth, int Weight, int Diameter1, int Depth1, int Weight1)
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
        //YouthBall
        this._Diameter1 = Diameter1;
        this._Depth1 = Depth1;
        this._Weight1 = Weight1;


    }
    public void CalculateAverageSpeed(float XRadius, float RoadLenght, float Time)
    {

        float result = Math.Abs((XRadius - RoadLenght) / Time);
        Console.WriteLine(result);

    }
    public void CalculateIfGoal(int BallCord, int GoalCord,int Diameter, double GoalDep)
    {

        double result = BallCord - (Diameter / 2);
        double result1 = GoalCord - GoalDep;
        if (result >= result1)
        {

            Console.WriteLine("Ball has hit goal");
        }
        else
        {
            Console.WriteLine("Ball has not hit goal");
        }






        }

    }
