using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb; // ссылка на компонент

    private void Start() 
        => rb = this.GetComponent<Rigidbody2D>(); // находим и получаем ссылку на "соседний" компонент объекта

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            rb.AddForce(Vector2.up * 350f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstracle")) 
            FindObjectOfType<GameManager>().GameOver();
        else if (other.gameObject.CompareTag("Scoring")) 
            FindObjectOfType<GameManager>().IncreaseScore();
    }
}

