using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private bool shootingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerController = player.GetComponent<PlayerController>();
        if(playerController.facingRight)
        {
            shootingRight = true;
        }
        else
        {
            shootingRight = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(shootingRight)
        {
            transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
        }
        if(!shootingRight)
        {
            transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Limite"))
        {
            Debug.Log("Chocó con limite");
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("Chocó con enemigo");
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
