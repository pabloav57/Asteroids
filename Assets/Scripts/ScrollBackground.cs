using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    [SerializeField] float speed;
    float height;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        height = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Scroll
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Reposicionar
        if(transform.position.y < -height)
            transform.Translate(Vector3.up * 2 * height);
    }
}
