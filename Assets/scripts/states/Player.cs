using System;
using Scenes.states;
using UnityEngine;

namespace Scenes
{
    public class Player : MonoBehaviour
    {
        public PlayerFsm playerFsm = null;
        public Movement movement;
        
        private void Start()
        {
            movement = GetComponent<Movement>();
            playerFsm = new PlayerFsm();
            
            playerFsm.add(new PlayerFsmStateMovement(this));
            playerFsm.add(new PlayerFsmStateAttack(this));
            
            playerFsm.setCurrentState(PlayerFsmStateType.MOVEMENT);
        }


        private void Update()
        {
            /*We just call update like this because we override the update
             in the actual state, so every state is gonna have its own update 
             */
            playerFsm.update();
        }
    }
}