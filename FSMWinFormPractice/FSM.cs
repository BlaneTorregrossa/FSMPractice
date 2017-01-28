using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void CallBack();

namespace FSMWinFormPractice
{

    class FSM<T>
    {


        public FSM()
        {
            states = new Dictionary<string, State>();
            
            {
          
            }

        }

        Dictionary<string, State> states;
       


        public void ChangeState(State hState)
        {
            

        }

        

        //public State GetState()
        //{

        //}

    }
}
