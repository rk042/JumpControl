using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

namespace JumpControl.Core
{    
    public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        PlayerJump player;

        private void Awake()
        {
            player=FindObjectOfType<PlayerJump>();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            player.StartPlayerJump();
        }

        public void OnPointerUp(PointerEventData eventData)
        {             
            player.StopPlayerJump();
        }
    }
}
