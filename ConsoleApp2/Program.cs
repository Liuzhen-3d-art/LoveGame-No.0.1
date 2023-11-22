using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace ConsoleApp2
{
  public class MyClass<T>
    {
        public T Name { get; set; }
        public T Year { get; set; }
        public T Month { get; set; }
        public T Day { get; set; }
        public T Hour { get; set; }
        
        

    }
    public class program
    {
        public Hashtable hashtable1 = new Hashtable();
        public static void Main()
        {
            //MyClass<prose> myClass1 = new MyClass<prose>();
            //prose prose1 = new prose() { Name = "小妞", Age = 19 };
            //myClass1.ItemName.Name = prose1.Name;
            //myClass1.ItemName.Age = prose1.Age;
            prose prose = new prose();
            //prose.GetStringOrInt("小明", "去学校");
            //prose.GetStringOrInt("小明", "回家");
            //prose.GetStringOrInt("小明", "去食堂");
            //prose.GetStringOrInt("小明", "去体育场");
            //prose.GetStringOrInt("小明", "去图书馆");
            //prose.GetStringOrInt("小明", "去约会");
            prose.TimeCalculator();
            


        }
    }
    public class prose
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static Timer timer;
        

        public Dictionary<object, object> dictionary = new Dictionary<object, object>();
       
        public void GetStringOrInt(object mitemName,object total)//万能转换器（支持修改同一键的的值，也可以添加新的键的值，用户可以在键值对上随意输入整型值和字符串值）
        {
            MyClass<object> myClass = new MyClass<object>();
            myClass.Name = mitemName;
            myClass.Day = total;
            try
            {
                dictionary.Add(myClass.Name, myClass.Day);
            }
            catch (Exception)
            {

                dictionary[mitemName] = total;
            }
            
            foreach (var item in dictionary)
            {
              
                    if(item.Key is string)
                    {
                        string ikey = item.Key as string;
                        Console.WriteLine($"键的值是{ikey}");
                    }
               
                    if(item.Key is int)
                {
                    int ikey = int.Parse(item.Key.ToString());
                    Console.WriteLine($"键的值是{ikey}");
                }
                    if(item.Value is string)
                {
                    string ivalue = item.Value as string;
                    Console.WriteLine($"值的值是{ivalue}");
                }
                if (item.Value is int)
                {
                    int ivalue = int.Parse(item.Value.ToString());
                    Console.WriteLine($"值的值是{ivalue}");
                }
               
            }
           
            
        }
        public void TimeCalculator()
        {
            string day = System.DateTime.Now.ToString("d");
            string time = System.DateTime.Now.ToString("t");
            DateTime datrObject = DateTime.Parse(day);
            DateTime timeObject = DateTime.Parse(time);
            MyClass<int> calender = new MyClass<int>();
            calender.Year = datrObject.Year;
            calender.Month = datrObject.Month;
            calender.Day = datrObject.Day;
            calender.Hour = timeObject.Hour;
            while (true)
            {
                calender.Hour++;
                if (calender.Hour >= 24)
                {
                    calender.Day++;
                    calender.Hour = 0;
                }
                if (calender.Day >= 31 && calender.Month == 1)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 28 && calender.Month == 2)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 31 && calender.Month == 3)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 30 && calender.Month == 4)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 31 && calender.Month == 5)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 30 && calender.Month == 6)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 31 && calender.Month == 7)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 31 && calender.Month == 8)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 30 && calender.Month == 9)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 31 && calender.Month == 10)
                {
                    calender.Month++;
                    calender.Day = 1;
                }

                if (calender.Day >= 30 && calender.Month == 11)
                {
                    calender.Month++;
                    calender.Day = 1;
                }
                if (calender.Day >= 31 && calender.Month == 12)
                {
                    calender.Month = 1;
                    calender.Day = 1;
                }
                if (calender.Month >= 12&&calender.Day>=30&&calender.Hour>=23)
                {
                    calender.Year++;
                }
                Console.WriteLine($"现在是{calender.Year}年{calender.Month}月{calender.Day}日{calender.Hour}时");
            }

        }
       
        




    }

}
