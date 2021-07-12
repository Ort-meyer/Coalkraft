using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorCard : Card
{

    public GameObject m_tractorPrefab;
    public Transform m_tractorSpawnPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void M_ActivateCard()
    {
        Instantiate(m_tractorPrefab, m_tractorSpawnPos.position, m_tractorSpawnPos.rotation);
    }
}
