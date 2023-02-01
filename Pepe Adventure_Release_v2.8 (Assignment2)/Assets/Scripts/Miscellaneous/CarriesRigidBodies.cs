using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriesRigidBodies : MonoBehaviour
{
    public List<Rigidbody2D> rigidbodies = new List<Rigidbody2D>();

    public Vector3 lastPosition;
    Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
        lastPosition = _transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(rigidbodies.Count > 0)
        {
            for (int i = 0; i < rigidbodies.Count; i++)
            {
                Rigidbody2D rb = rigidbodies[i];
                Vector3 velocity = (_transform.position - lastPosition);
                rb.transform.Translate(velocity, _transform);
            }
        }

        lastPosition = _transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody.GetComponent<Rigidbody2D>();
        if(rb != null)
        {
            Add(rb);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.attachedRigidbody.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Remove(rb);
        }
    }

    void Add(Rigidbody2D rb)
    {
        if (!rigidbodies.Contains(rb))
            rigidbodies.Add(rb);
    }

    void Remove(Rigidbody2D rb)
    {
        if (rigidbodies.Contains(rb))
            rigidbodies.Remove(rb);
    }
}
