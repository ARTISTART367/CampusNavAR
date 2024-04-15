using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    
    public enum Scene
    {
        Home,
        Nav1flr2,
        Profile,
        Login,
        Signup

    }

    public void LoadScene(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public void LoadHome()
    {
        SceneManager.LoadScene(Scene.Home.ToString());
    }

    public void LoadNav1flr2()
    {
        SceneManager.LoadScene(Scene.Nav1flr2.ToString());
    }

    public void LoadProfile()
    {
        SceneManager.LoadScene(Scene.Profile.ToString());
    }

    public void LoadLogin()
    {
        SceneManager.LoadScene(Scene.Login.ToString());
    }

    public void LoadSignup()
    {
        SceneManager.LoadScene(Scene.Signup.ToString());
    }

    
}
