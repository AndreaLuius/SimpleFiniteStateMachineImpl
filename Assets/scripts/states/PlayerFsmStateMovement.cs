using UnityEngine;

namespace Scenes.states
{
    public class PlayerFsmStateMovement : PlayerFsmState
    {
        public PlayerFsmStateMovement(Player player) 
            : base(player)
        {
            id = PlayerFsmStateType.MOVEMENT;
        }

        public override void enter()
        {
            base.enter();
        }

        public override void update()
        {
            Debug.Log("movement State update update");
            base.update();
            player.movement.movementHandling();

            if (Input.GetKeyDown(KeyCode.X))
            {
                var attackState = (PlayerFsmStateAttack) player.playerFsm.getState(PlayerFsmStateType.ATTACK);

                player.playerFsm.setCurrentState(PlayerFsmStateType.ATTACK);
            }
        }
    }
}