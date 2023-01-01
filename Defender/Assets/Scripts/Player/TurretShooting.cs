using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShooting : MonoBehaviour
{
    private float bulletDamage = 50f;
    private ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        * If the user clicks, shoot the gun/particle.
        */
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
           
        }
    }

    private void OnParticleCollision(GameObject otherObj) {
        /*
        * If the component that was collided was an enemy, deal damage to that enemy.
        */
        if (otherObj.transform.root.TryGetComponent(out Enemy enemy)) {
            enemy.takeDamage(this.bulletDamage);
        }
    }
}
