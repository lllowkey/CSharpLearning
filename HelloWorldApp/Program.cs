using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace HelloWorldApp
{
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

            System.IO.File.Create("E:\\HellowWorld.txt");

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
            uint x = uint.MaxValue;
            Console.WriteLine(x);

            var binStr = Convert.ToString(x, 2);
            Console.WriteLine(binStr);



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
    class Student
    {
        public string Name;
        public int Score;
        public void Report()
        {
            Console.WriteLine("Im a student");
        }
    }

    class CsStudent : Student
    {
        new public void Report()
        {
            Console.WriteLine("Im a CsStudent");
        }
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
