using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gamekit2D
{
    public class boss : MonoBehaviour
    {
        public float speed; //hraði 
        public bool vertical; //lóðrétt
        public float changeTime = 3.0f;

        Rigidbody2D rigidbody2D;//setur rigidbody á boss
        float timer;
        int direction = 1;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
            timer = changeTime;
           
        }

       
        void Update()
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                direction = -direction;
                timer = changeTime;
            }
        }

        void FixedUpdate()
        {
            
            Vector2 position = rigidbody2D.position; // boss hreyfir sig 

            if (vertical)
            {
                position.y = position.y + Time.deltaTime * speed * direction; ;
            }
            else
            {
                position.x = position.x + Time.deltaTime * speed * direction; ;
            }

            rigidbody2D.MovePosition(position);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Damageable controller = collision.GetComponent<Damageable>();
            controller.GainHealth(-1);
            Destroy(gameObject);// eyði leggur boss eftir að hann missir allt líf
        }

    }
}
