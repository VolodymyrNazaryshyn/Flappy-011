using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearScript : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log(other.name);
        GameObject.Destroy(other.gameObject.transform.parent.gameObject);
    }
}
/* OnTriggerEnter2D - событие, возникающее при пересечении коллайдера, у
 * которого тип - триггер (перекладывает обработку колизии на скрипт -
 * физика на него не действует)
 */