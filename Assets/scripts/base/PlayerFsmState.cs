namespace Scenes.states
{
    public class PlayerFsmState : State
    {
        protected PlayerFsmStateType id;
        protected Player player;
        
        public PlayerFsmState(Fsm fsm,Player player) 
            : base(fsm)
        {
            this.player = player;
        }

        public PlayerFsmState(Player player)
        {
            this.player = player;
            fsm = player.playerFsm;
        }

        public override void enter()
        {
            base.enter();
        }

        public override void exit()
        {
            base.exit();
        }

        public override void update()
        {
            base.update();
        }

        public override void fixedUpdate()
        {
            base.fixedUpdate();
        }


        #region Properties
        public PlayerFsmStateType ID {get{ return id; }}
        #endregion
    }
}