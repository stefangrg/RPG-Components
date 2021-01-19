using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManager : MonoBehaviour
{

    #region Singleton
    private static EntityManager m_instance;
    public static EntityManager Instance
    {
        get
        {
            if (m_instance == null)
                m_instance = FindObjectOfType<EntityManager>();
            return m_instance;
        }
    }
    #endregion

    public List<Entity> entities = new List<Entity>();

    private void Awake()
    {
        if (Instance != this) Destroy(gameObject);
    }

    void Start()
    {
        Entity[] childrens = FindObjectsOfType<Entity>();
        foreach(Entity entity in childrens)
        {
            entities.Add(entity);
        }
    }

    public void SpawnEntity(Entity entity,Transform location, Quaternion rotation)
    {

    }
}
