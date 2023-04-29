using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


    public enum Menu_Animation
    {
        PLAYER_COLLIDE_WITH_THE_WELL
    }
 

   

    public class MenuManager : MonoBehaviour
    {
    // Start is called before the first frame update


    public GameObject[] _list_Panels;
    public GameObject _menuPanel;
     public C_GameSettings Settings ;
        public static MenuManager Instance { get; private set; }

        
        private Animator animator;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }
        void Start()
        {
            try
            {

                if (_menuPanel == null)
                {
                    throw new UnityException("The panel is not defined");

                }
            animator = _menuPanel.GetComponent<Animator>();

            _menuPanel.SetActive(false);
         

            }

            catch (UnityException ex)
            {
                Debug.Log(ex.Message);

            }
        Load_MenuManager_Settings();



        }

        // Update is called once per frame
        void Update()
        {

        }
        public void Show_Hide_MenuPanel(bool show = false)
        {
            _menuPanel.SetActive(show);

        }

    public void Start_Showing_Animation(bool Stop_animation = false)
    {
        animator.SetBool("Hide", false);

    }
    public void Stop_showing_Animation()
    {
        animator.SetBool("Hide", true);
       
    }

    public void Load_MenuManager_Settings()
    {
     
        Settings.Set_Settings_view();
        Debug.Log("Settings are updated");

    }

    public void Save_Nenu_Manager_Setting()
    {
        Settings.Update_Settings();

    }


    private void OnDestroy()
    {
        Save_Nenu_Manager_Setting();
    }

}


