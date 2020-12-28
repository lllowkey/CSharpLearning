using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace HelloWorldApp
{
    public delegate double CalcDelegate(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            /*Form myForm = new Form();
            double result = Calculator.add(3.5, 3.2);
            //Console.WriteLine(result);
            Form form = new Form();
            form.Text = "Hello";
            form.WindowState = FormWindowState.Normal;
            form.ShowDialog();
            Student stu = new Student(1,"1");*/
            /*double result = Calculator.GetConeVolume(100, 90);
            Console.WriteLine(result);*/

            /*自定义操作符*/
            /*Person person1 = new Person();              
            Person person2 = new Person();
            person1.Name = "Deer";
            person2.Name = "Deer's wife";
            List<Person> nation = person1+person2;
            foreach (var p in nation)
            {
                Console.WriteLine(p.Name);
            }*/

            //System.IO.File.Create("E:\\HellowWorld.txt");

            /*委托*/
            /*Calculator c = new Calculator();
            Action myAction = new Action(c.PrintHello);
            myAction();*/

            /*字典*/
            /*Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
            for (int i = 0; i <= 100; i++)
            {
                Student stu = new Student();
                stu.Name = "s_" + i.ToString();
                stu.Score = 100+i;
                stuDic.Add(stu.Name,stu);
            }

            Student number6 = stuDic["s_99"];
            Console.WriteLine(number6.Score);*/

            /*typeof*/
            // Metadata
            /*Type t = typeof(int);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);

            int c = t.GetMethods().Length;
            Console.WriteLine(c);
            foreach (var m in t.GetMethods())
            {
                Console.WriteLine(m.Name);
            }*/

            /*default*/
            /*Level x = default(Level);
            Console.WriteLine(x);*/

            /*匿名类--该句意为用隐式类型变量(var)引用该匿名类用new创建的对象*/
            /*var person = new { Name = "Mr.ok", Age = 34 };
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetType().Name);*/

            /*new作为修饰符隐藏父类方法*/
            /*Student stu = new Student();
            stu.Report();
            CsStudent csStu = new CsStudent();
            csStu.Report();*/

            /*checked&uncheck*/
            /* uint x = uint.MaxValue;
             Console.WriteLine(x);

             var binStr = Convert.ToString(x, 2);

             unchecked
             {
                 try
                 {
                     uint y = checked(x + 1);
                     Console.WriteLine(y);
                 }
                 catch (OverflowException ex)
                 {

                     Console.WriteLine("overflow");
                 }
             }*/

            /*->操作指针*/
            /*unsafe
            {
                Student stu;
            stu.ID = 1;
            // 用 . 直接访问
            stu.Score = 99;

            Student* pStu = &stu;
            // 用 -> 间接访问
            pStu->Score = 100;

            Console.WriteLine(stu.Score);

            }*/

            /*int x = 12345678;
            Console.WriteLine(x);
            int y = ~x; 
            Console.WriteLine(y);
            int z = y + 1;
            Console.WriteLine(z);

            var xStr = Convert.ToString(x, 2).PadLeft(32, '0');
            var yStr = Convert.ToString(y, 2).PadLeft(32, '0');
            Console.WriteLine(xStr);
            Console.WriteLine(yStr);*/

            /*String str1 = Console.ReadLine();
            int x = Convert.ToInt32(str1);
            Console.WriteLine(x);*/

            /*装箱后父类无法使用子类的方法*/
            /*Teacher t = new Teacher();
            Human h = t;
            Animal a = h;
            a.Eat();*/

            /*自定义操作符*/
            /*Stone stone = new Stone();
            stone.Age = 5000;
            Monkey wukong = (Monkey)stone;
            Console.WriteLine(wukong.Age);*/

            /*可空类型*/
            /*Nullable<int> x = null;
            int? y = null;*/

            /*var x = 5 > 3 ? 2 : 3.0;
            Console.WriteLine(x);
            Console.WriteLine(x.GetType());

            var v = typeof(Int32);
            Console.WriteLine(v);

            Form myForm = new Form();
            myForm.Text = "HELLO";
            myForm.Load += MyForm_Load;*/

            /*拓展方法*/
            /*double x = 3.01415926;
            double y = x.Round(4);*/

            /*LinQ*/
            /*var myList = new List<int>() { 11, 12, 9, 14, 15 };
            //bool result = AllGreaterThanTen(myList);
            // 这里的 All 就是一个扩展方法
            bool result = myList.All(i => i > 10);
            Console.WriteLine(result);*/

            /*委托的使用*/
            /*CalculatorDemo calculator = new CalculatorDemo();
            Action action = new Action(calculator.Report);
            calculator.Report();
            action.Invoke();
            action();

            Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);

            int x = 100;
            int y = 200;
            int z = 0;

            z = func1(x, y);
            Console.WriteLine(z);
            z = func2(x, y);
            Console.WriteLine(z);*/

            /*自定义委托--委托也是一种类*/
            Type t = typeof(Action);
            Console.WriteLine(t.IsClass);
            
            DelegateCalculator calculator = new DelegateCalculator();
            /*public delegate double CalcDelegate(double x, double y);*/
            CalcDelegate calc1 = new CalcDelegate(calculator.Add);
            CalcDelegate calc2 = new CalcDelegate(calculator.Sub);
            CalcDelegate calc3 = new CalcDelegate(calculator.Mul);
            CalcDelegate calc4 = new CalcDelegate(calculator.Div);

            double a = 100;
            double b = 200;
            double c = 0;

            c = calc1.Invoke(a, b);
            Console.WriteLine(c);
            c = calc2.Invoke(a, b);
            Console.WriteLine(c);
            c = calc3.Invoke(a, b);
            Console.WriteLine(c);
            c = calc4.Invoke(a, b);
            Console.WriteLine(c);
        }
        static bool AllGreaterThanTen(List<int> intList)
        {
            foreach (var item in intList)
            {
                if (item <= 10)
                {
                    return false;
                }
            }

            return true;
        }
        private static void MyForm_Load(object sender, EventArgs e)
        {
            Form form = sender as Form;
            if (form == null)
            {
                return;
            }
            form.Text = "new Title";

        }
        /*索引器*/
        private Dictionary<String, int> scoreDictionary = new Dictionary<string, int>();

        public int? this[String subject]
        {
            get
            {
                if (scoreDictionary.ContainsKey(subject))
                {
                    return scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue == false)
                {
                    throw new Exception("Score cannot be null");
                }

                if (scoreDictionary.ContainsKey(subject))
                {
                    //  可空类型的 Value 属性才是其真实值。
                    scoreDictionary[subject] = value.Value;
                }
                else
                {
                    scoreDictionary.Add(subject, value.Value);
                }
            }
        }

    }

    class DelegateCalculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

    }

    class CalculatorDemo
    {
        public void Report()
        {
            Console.WriteLine("i have 3 methods");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    static class DoubleExtension
    {
        public static double Round(this double input, int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }

    struct color
    {
        public int Red;
        public int Green;
        public int Blue;

    }

    class Brush
    {
        public static readonly color DefaultColor;
        static Brush()/*静态构造器*/
        {
            Brush.DefaultColor = new color { Red = 0, Green = 0, Blue = 0 };
        }
    }
    class Stone
    {
        public int Age;

        public static explicit operator Monkey(Stone stone)
        {
            Monkey m = new Monkey();
            m.Age = stone.Age / 500;
            return m;
        }
    }

    class Monkey
    {
        private int age;

        public int Age { get => age; set => age = value; }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("Who i am?");
        }
    }

    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("I teach programmming");
        }
    }

    enum Level
    {
        Low=1,
        Mid=2,
        High=3
    }

    public class Person
    {

        
        
        public String Name;
        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> people = new List<Person>();
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + "&" + p2.Name + "'s child";
                people.Add(child);
            }
            return people;
        }
    }
    struct Student
    {
        public int ID;
        public string Name;
        public long Score;
    }


    class Calculator
    {

        public static double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }

        public static double GetCylinderVolume(double r, double h)
        {
            double a = GetCircleArea(r);
            return a * h;
        }

        public static double GetConeVolume(double r, double h)
        {
            double cv = GetCylinderVolume(r, h);
            return cv / 3;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
