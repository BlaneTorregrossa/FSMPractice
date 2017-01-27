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

    enum Weather
    {
        INIT = 0,
        NOWIND = 1,
        LIGHTWIND = 2,
        EXTREMEWIND = 3,
        END = 1000, 
    }
    class Program
    {

       


        static void Main(string[] args)
        {
         

        }


        static public void ActionA()
        {


        }





    }
}
