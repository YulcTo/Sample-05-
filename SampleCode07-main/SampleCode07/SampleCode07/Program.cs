using SampleCode07;


public class Program
{
    private static readonly double[] array = 
    {
        980.0969548024685,
        448.7701170278722,
        476.8396994574119,
        323.87896643249525,
        137.9586537219506,
        183.8177389107478,
        568.6475922417197,
        540.5221554309112,
        60.486847789444134,
        280.0067951846643,
        327.41532924796326,
        916.0709759441389,
        923.7515600275211,
        817.6131103197356,
        396.07448778419587,
        413.5932681191092,
        846.7432663558135,
        90.293040240928,
        822.429870469622,
        475.30153544624557
    };

    public static void Main(string[] args)
    {
        Func<double[], double> getRepresentativeValue = array => 
            {
                //平均値を出す
                double sum = 0.0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum / array.Length;
            };


        //↑とは別の場所に書かれている想定
        double rValue = getRepresentativeValue.Invoke(array);
        Console.WriteLine("代表値:" + rValue);
    }

    private static void Handson01()
    {
        RepresentativeValueCalculator calclator =
            new RepresentativeValueCalculator(new Median());




        //↑とは別の場所に書かれている想定
        double rValue = calclator.GetRepresentativeValue(array);
        Console.WriteLine("代表値:" + rValue);


        /*
        //ランダムdouble配列をソースコードとして得る
        double[] array = CreateRandomDoubleArray(20);
        Console.WriteLine(GetArrayCode(array));
        */
    }

    //ランダムなdouble配列を作る
    private static double[] CreateRandomDoubleArray(int length)
    {
        Random random = new Random();
        double[] ret = new double[length];

        //0～1000までの範囲でランダムにdouble配列を作る
        for (int i = 0; i < length; i++)
        {
            ret[i] = random.NextDouble() * 1000.0;
        }
        return ret;
    }

    private static string GetArrayCode(double[] array)
    {
        string ret = "{\n" + array[0].ToString();
        for (int i = 1;i < array.Length;i++)
        {
            ret += ",\n" + array[i].ToString();
        }
        ret += "}";
        return ret;
    }

    public static void Handson03()
    {
        Func<int, int, string> func = DelegateFunctions.Power;

        string result = func.Invoke(15, 4);
        Console.WriteLine(result);
    }

    public static void Handson04()
    {
        //ラムダ
        Func<int, int, string> sum = (a, b) => (a + b).ToString();
        //Func<int, int, int> multiply = (a, b) => a * b;

        string result = sum.Invoke(15, 4);
        Console.WriteLine(result);
    }
}