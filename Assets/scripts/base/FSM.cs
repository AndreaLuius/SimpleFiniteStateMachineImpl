using System.Collections.Generic;

namespace Scenes
{
    public class Fsm
    {
        protected Dictionary<int, State> states = new Dictionary<int, State>();
        public State currentState;
        
        public Fsm()
        {
        }

        public void addState(int key, State newState)
        {
            states.Add(key,newState);
        }
        
        public State getState(int key)
        {
            return states[key];
        }

        public void setCurrentState(State state)
        {
            if(currentState != null)
                currentState.exit();
            
            currentState = state;
            
            if(currentState != null)
                currentState.enter();
        }

        public void update()
        {
            if(currentState != null)
                currentState.update();
        }

        public void fixedUpdate()
        {
            currentState.fixedUpdate();
        }
    }
}