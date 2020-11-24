using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nut : MonoBehaviour
{
    //[SerializeField] Sprite deadSprite;
    [SerializeField] ParticleSystem particleSyetem;
    
    bool hasDied;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Floor")
            return;

        StartCoroutine(Die());
    }
    
    IEnumerator Die()
    {
        hasDied = true;
        //GetComponent<SpriteRenderer>().sprite = deadSprite;
        particleSyetem.Play();

        yield return new WaitForSeconds(1);

        gameObject.SetActive(false);
    }
}
