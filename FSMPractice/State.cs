using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMPractice
{
    class State
    {

       //CallBack onEnter;
        public delegate void OnEnter();
        public OnEnter onEnter;

        //CallBack onExit;
        public delegate void OnExit();
        public OnExit onExit;

        public State() { }

        public State (Enum e)
        {

        }
       
        public void AddEnterFunction(Delegate d)
        {
            
        }

        

    }
}
