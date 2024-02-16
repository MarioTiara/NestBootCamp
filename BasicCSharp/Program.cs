
using System;
using System.Collections;
using System.Text.Json;
using Microsoft.VisualBasic;
using MyLib;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] myArr = new string[5];
        string[] myArr1 = { "index1", "index2", "index3" };

        List<string> myList = new List<string>(){ "index1", "index1", "index3" };
        
        LinkedList<string> myLinkedlist = new ();
        var myLinkedlist1 = new LinkedList<int>();
        

        Dictionary<string, List<string>> myDict= new ();

        myDict.Add("adi", new List<string>(){"0iioio", "0ifieofio"});
        myDict["adi"].Add("o445i454iui4");

        var testClass = new Class1();

        // myList.Remove("index1");
        // myList.RemoveAt(1);
        
        //myList.Remove().Where
       /// Console.WriteLine(JsonSerializer.Serialize(myList));

    
        
    



        // foreach (string element in myArr1)
        // {
        //     if (element=="index1")
        //         break;
        //     else {
        //         Console.WriteLine(element);
        //     }
        // }

        // for (int i=0 ; i<myArr1.Length;  i++)
        // {
        //     Console.WriteLine(myArr1[i]);
        // }
        // myArr[2] = "new value";

        // string myStstring = "ini string";
        // string myStstrin1 = "ini string";

        // int umur = 17;
        // string name = "Ari";

        // string myString3 =$"nama saya {name} umur saya {umur}";
        // string myString4= string.Format("nama saya {0} umur saya {1}", name, umur);
        
        
        
       

        var mario = new Person("mario", 17);
        
        var pegawai= new Pegawai();
        
        // mario.Name="mario";
        // mario.Umur=18;

        // mario.PrintIdenitity();
        // var Juki = new Person();
        // mario.Name="Juki";
        // mario.Umur=18;

        // List<Person> people= new ();

        // people.Add(mario);
        // people.Add(Juki);

        //  LinkedList<Person> people2= new ();

        //  people2.AddLast(mario);


        //  Dictionary<string, Person> persons= new ();

    }

    public class Person
    {


        private string Name {get;set;}
        public int  Umur {get;set;}

        public void SetName (string name)
                => this.Name=name;

        protected string MyProp {get;set;}

        public Person(string name, int umur)
        {
            this.Name= name;
            this.Umur= umur;
        }

        // public Person()
        // {
            
        // }

        public void PrintIdenitity ()
        {
            Console.WriteLine($"My name is {this.Name} and my age is {Umur} ");
        }

    }

    public class Pegawai : Person
    {
        public Pegawai(string name, int umur) : base(name, umur)
        {
        }

        public void Test()
        {
            Console.WriteLine(base.MyProp);
        }
    }
}