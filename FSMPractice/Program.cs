using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
            INIT transitions to NOWIND upon the condition of an input of s
            NOWIND transitions to LIGHTWIND upon the condition of an input of l
            NOWIND transitions to EXTREMEWIND upon the condition of an input of e
            LIGHTWIND transitions to NOWIND upon the condition of an input of n
            LIGHTWIND transitions to EXTEMEWIND upon the condition of an input of e
            EXTREMEWIND transitions to LIGHTWIND upon the condition of an input of l
            EXTREMEWIND transitions to NOWIND upon the condition of an input of n
            EXTREMEWIND transitions to END upon the condition of an input of q
     
 */


namespace FSMPractice
{


    delegate void CallBack();


    class Program
    {

        int NumA = 25;
        int NumB = 256;
        int NumC = 8;
        int sum;
        string WordA = "Hello!";


        static void Main(string[] args)
        {
            FSM test = new FSM();


        }


        static public void ActionA()
        {
            Console.Write("I have ants in my eyes.");
        }


        static public void ActionB()
        {
            
        }


        static public void ActionC()
        {

        }


        static public void ActionD()
        {

        }

        static public void ActionE()
        {

        }

    }
}
