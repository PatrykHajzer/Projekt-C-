using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    public static System.Action<Player> OnLocalPlayerJoined;
    private GameObject gameObject;

    private static GameManager m_Instance;
    public static GameManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = new GameManager();
                m_Instance.gameObject = new GameObject("_gameManager");
            }
            return m_Instance;
        }
    }
    private InputController m_InputController;
    public InputController InputController
    {
        get
        {
            if (m_InputController == null)
                m_InputController = gameObject.GetComponent<InputController>();
            return InputController;
        }
    }
    private Player m_LocalPlayer;
    public Player LocalPLayer
    {
        get
        {
            return m_LocalPlayer;
        }
        set
        {
            m_LocalPlayer = value;
            if (OnLocalPlayerJoined != null)
                OnLocalPlayerJoined();
        }
    }
}

