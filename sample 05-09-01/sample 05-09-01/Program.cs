// See https://aka.ms/new-console-template for more information

//using CarClas;
//using ClasTester01;


//Console.WriteLine("クラスのサンプルプログラム");

//Car carInstance = new Car(10f);

//Car carInstance2 = new Car(3f);

//carInstance2.Position_a = 1f;
//carInstance2.Position_b= 1f;
//carInstance2.Position_c=1f;

//Console.WriteLine(carInstance.Position);
//carInstance.Rune(3f);
//carInstance2.Rune(3f);
//Console.WriteLine(carInstance2.Position_a);
//Console.WriteLine(carInstance2.Position_b);
//Console.WriteLine(carInstance2.Position_c);


//Console.WriteLine(carInstance.Position);
//Class1.HansOn(carInstance);
//Console.WriteLine(carInstance.Position);

/*10-13 Smplecod07*/
public class Smple07
{
    public static readonly double[] array =
    {
            1.134646846,
            0.2648465465,
            54.844654646,
            6.04084654608,
            35.534036840646,
            464603.540464,
            6.464651356464,
        };


    //public static void Main(string[] args)
    //{
    //        RepresentaiveValueCalculator calclator =
    //        new RepresentaiveValueCalculator(new Madian);

    //        double rvalue = calclator.GetRepresentativeValue(array);
    //        Console.WriteLine("代表値"+rvalue);
    //}



    //    public static double Doublearry(int length)
    //    {
    //        Random random = new Random();
    //        double[] ret=new double[length];
    //        for (int i = 0; i < length; i++)
    //        {
    //            ret[i]=random.NextDouble()*1000.0;
    //        }
    //        return ret[length];
    //    }

    //}

    /*ハンズオン03*/
    //public static void Main(string[] args)
    //{

    //    //Func<int, int, string> func = Delegate;

    //    Func<int, int, string> sum = (a, b)
    //        => (a + b).ToString();

    //    string result = sum.Invoke(15, 4);
    //    Console.WriteLine(result);
    //}

    /*ハンズオン04*/
    public static void Main(string[] args)
    {
        Func<double[], double> getRepresentativeValue = array=>
         {
             double sum = 0.0;
             for (int i = 0; i < array.Length; i++)
             {
                 sum += array[i];
             }
             return sum / array.Length;
         };

        double rvalue = getRepresentativeValue.Invoke(array);
        Console.WriteLine("代表値: " + rvalue);
    }
}