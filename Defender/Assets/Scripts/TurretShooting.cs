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
        /*
        * Assigning the particle system of the game object. You can do it this way or just drag the particle system directly in the Unity Editor.
        */
        this.particleSystem = GetComponent<ParticleSystem>();

        // Access the shape module of the particle system
        var shapeOfParticle = this.particleSystem.shape;
        
        // Randomize the direction which the particles go to.
        shapeOfParticle.randomDirectionAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        * If the user clicks, shoot the gun/particle.
        */
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            particleSystem.Play();
        }
    }

    private void OnParticleCollision(GameObject otherObj) {
        /*
        * If the component that was collided was an enemy, deal damage to that enemy.
        */
        if (otherObj.transform.root.TryGetComponent(out EnemyDamage enemy)) {
            enemy.takeDamage(this.bulletDamage);
        }
    }
}
