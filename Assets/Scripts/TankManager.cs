using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankManager : MonoBehaviour
{
    private void Awake()
    {
        Debug.Assert(NumTanks >= 2, "number of players cannot be less than 2");
        Debug.Assert(m_tankPrefab != null, "Tank Prefab need to be assigned");

        m_tanks = new Tank[NumTanks];

        for(int i = 0; i < NumTanks; ++i)
        {
            m_tanks[i] = Instantiate<Tank>(m_tankPrefab, transform);
        }

        m_tankPrefab = null;

        DistributeTanks();

        SetStartingTank();
    }

    private void SetStartingTank()
    {
        m_currentTank = m_tanks[Random.Range(0, NumTanks)];
        m_currentTank.GiveTurn();
    }

    private void DistributeTanks()
    {
        for (int i = 0; i < NumTanks; ++i)
        {
            m_tanks[i].transform.Translate(Vector3.right * (i % 2 == 0 ? 1 : -1));
        }
    }


    #region Members
    public int NumTanks;

    public Tank m_tankPrefab;

    public ITank[] m_tanks;
    public ITank m_currentTank;
    #endregion
}
