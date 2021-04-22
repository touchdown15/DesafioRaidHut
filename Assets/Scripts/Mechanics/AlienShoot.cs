using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /*/// <summary>
    /// A simple controller for enemies. Provides movement control over a patrol path.
    /// </summary>
    [RequireComponent(typeof(AnimationController), typeof(Collider2D))]*/

    public class AlienShoot : EnemyController
    {

        public float speed;
        private float timeDestroy = 4f;

        // Update is called once per frame
        void Update()
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x-3, transform.position.y), speed*Time.deltaTime);
            Object.Destroy(gameObject, timeDestroy);
        }

        private void OnTriggerEnter2D(Collider2D other) {
            
            var player = other.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                var ev = Schedule<PlayerEnemyCollision>();
                ev.player = player;
                ev.enemy = this;
            }
            
            if(other.gameObject.name == "Player"){

            }
        }

    }
}