using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FSMPractice
{
    class FSM
    {

        CallBack onTest;
        CallBack onAltTest;
        

        public FSM()
        {

            onTest = null;

        }

        public void AddStuffToTest(CallBack T, CallBack A)
        {
            onTest += T;
            onAltTest += A;
        }

        //public void Test()
        //{
        //    if (onTest != null)
        //        onTest.Invoke();

        //}


        //public void AltTest()
        //{
        //    if (onAltTest != null)
        //        onAltTest.Invoke();

        //}

        




        Dictionary<string, State> states;
        State cState;
        public void StateChange(State s)
        {
           

        }

        public void StateDictionary()
        {
            states = new Dictionary<string, State>();


        }


        

        //public void StateChange(State s)
        //{
           

        //}

        
        //public void StateTransistions()
        //{


        //}



        //public bool Start()
        //{
        //    return true;
        //}

    }
}
