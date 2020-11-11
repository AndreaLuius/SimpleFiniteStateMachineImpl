using UnityEngine;

namespace Scenes.states
{
    public class PlayerFsmStateAttack : PlayerFsmState
    {
        public PlayerFsmStateAttack(Player player) 
            : base(player)
        {
            id = PlayerFsmStateType.ATTACK;
        }


        /*Its not a must to override all the virtual methods we
         specified, it depends by what you need*/
        public override void enter()
        {
            Debug.Log("entering attack state");
        }
        
        public override void exit()
        {
            Debug.Log("exiting the attack state");
        }

        public override void update()
        {
            // Debug.Log("Attack State Update");
            if(Input.GetKeyDown(KeyCode.X))
                fire();
            else
                player.playerFsm.setCurrentState(PlayerFsmStateType.MOVEMENT);
            
        }

        public void fire()
        {
            Debug.Log("BOoM BOoM");
        }
    }
}