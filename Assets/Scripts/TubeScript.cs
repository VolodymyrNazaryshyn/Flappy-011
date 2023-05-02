using UnityEngine;

public class TubeScript : MonoBehaviour
{
    [SerializeField] private float tubeSpeed = 1f;

    private void Update() =>
        this.transform.Translate(Vector2.left * (tubeSpeed * 2 * Time.deltaTime));
}
