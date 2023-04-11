namespace Point_Timer
{
    internal class Program
    {


        class Point
        {
            int _x;
            int _y;

            // Default constructor
            public Point()
            {
                X = 0;
                Y = 0;
            }

            // Param constructor
            public Point(int x, int y)
            {
                X=x;
                Y=y;
            }
            
            // Copy constructor
            public Point(in Point other)
            {
                _x = other._x;
                _y = other._y;
            }

            // Full properties for X & Y 
            public int X { get { return _x; } set { _x = value; } }
            public int Y { get { return _y; } set { _y = value; } }

            // To_String overrider
            public override string ToString()
            {
                return $"{X};{Y}";
            }

        }




        class Timer
        {
            int _minvalue;
            int _maxvalue;
            int _currentvalue;


            // Defualt constructor
            public Timer()
            {
                Min = 0;
                Max = 10;
                Current = Min;
            }

            // Param constructor
            public Timer(int minvalue,int maxvalue)
            {
                Min= minvalue;
                Max = maxvalue;
                Current = Min;
            }

            // Min Property
            public int Min { 
                get { return _minvalue; } 
                set 
                {
                    if (value < 0) _minvalue = 0;
                    else _minvalue = value;
                } 
            }

            // Max property
            public int Max
            {
                get { return _maxvalue; }
                set
                {
                    if (value <= _minvalue) _maxvalue = value + 10;
                    else _maxvalue = value; 
                }
            }

            // Current property
            public int Current
            {
                get { return _currentvalue; }
                set
                {
                    if(value-1==_maxvalue) _currentvalue = _minvalue;
                    else _currentvalue = value;
                }
            }

            // Increment
            public void Increment()
            {
                Current=Current+1;
            }

            // To_string overrider
            public override string ToString()
            {
                return $"Min Value: {Min}\nMax Value: {Max}\nCurrent Value: {Current}";
            }

        }


        static void Main(string[] args)
        {

            // Point Class
            {
                //Point point = new Point();
                //point.X = 12;
                //point.Y = 24;
                //Point point2 = new Point(point);
                //point2.X = 68;
                //point2.Y = 17;
                //Console.WriteLine(point);
                //Console.WriteLine(point2);

            }

            // Timer Class
            //{
            //    Timer timer = new Timer(36,36);

            //    for (int i = 0; i < 11; i++)
            //    {
            //        timer.Increment();
            //        Console.WriteLine(timer);
            //        Console.WriteLine();
            //    }
            //}




        }
    }
}