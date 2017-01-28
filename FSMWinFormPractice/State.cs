using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMWinFormPractice
{

   

    class State
    {

        public State() { }

        



        public delegate void OnEnter();
        public OnEnter onEnter;

        public delegate void OnExit();
        public OnExit onExit;

        


    }
}
