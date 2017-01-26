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

        public void Test()
        {
            

        }


        public void AltTest()
        {


        }


        //Dictionary<String, State> states;
        //State aState; /*State bState; State cState; State dState; State eState;*/


        //public void StateChange(State s)
        //{
        //    aState.exitState();
        //    // aState.Equals();
        //    aState = s;
        //    //s.enterState();
        //    aState.enterState();

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
