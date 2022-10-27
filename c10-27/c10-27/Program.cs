using c10_27;
using System.Linq;

public class Program
{



    public static void Main(string[] args)
    {

        Handson08 date;
        try 
        { 

            System.Net.WebClient wc = new System.Net.WebClient();
            string json = wc.DownloadString("https://www.stopcovid19.jp/data/covid19japan.json");


         Handson08? dat = Newtonsoft.Json.JsonConvert.DeserializeObject<Handson08>(json);
            if (dat == null) return;
            date = dat;


            


        }
        catch
        {
            return;
        }

        //Console.WriteLine(date.area[0].name_jp + ":" + date.area[0].ncurrentpatients);


       var oderby= date.area.OrderBy(area => -area.ncurrentpatients).ToArray();
        Console.WriteLine("現在の感染者数Top５");
        for(int i = 0; i < 5; i++)
        {
            var area = oderby[i];
            Console.WriteLine(area.name_jp + ":" + area.ncurrentpatients);
        }

        //Console.WriteLine("現在の感染率Top5");
        //var oderyle = date.area.S;
        //for (int i = 0; i < 5; i++)
        //{
        //    var area = oderby[i];
        //}

        var oderbyfa = date.area.OrderBy(area => -((double)area.nheavycurrentpatients)).ToArray();
        Console.WriteLine("現在の重症率Top"+oderbyfa);


    }
  



}