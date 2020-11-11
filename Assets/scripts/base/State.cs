namespace Scenes
{
    public class State
    {
        protected Fsm fsm;
        
        public State(Fsm fsm)
        {
            this.fsm = fsm;
        }

        public State()
        {
        }

        public virtual void enter()
        {
            
        }

        public virtual void exit()
        {
            
        }
        
        public virtual void update()
        {
            
        }

        public virtual void fixedUpdate()
        {
            
        }
    }
}