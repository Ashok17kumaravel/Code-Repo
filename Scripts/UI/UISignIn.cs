using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UISignIn : MonoBehaviour
{

    [SerializeField] Text errorText;
    

    string username, password;

    void OnEnable()
    {
        UserAccount.OnSignInFailed.AddListener(OnSignInFailed);
        UserAccount.OnSignInSuccess.AddListener(OnSignInSuccess);
    }

    void OnDisable()
    {
        UserAccount.OnSignInFailed.RemoveListener(OnSignInFailed);
        UserAccount.OnSignInSuccess.RemoveListener(OnSignInSuccess);
    }
    void OnSignInFailed(string error)
    {
        errorText.gameObject.SetActive(true);
        errorText.text = error;
    }

    void OnSignInSuccess()
    {
        SceneManager.LoadScene(1);
    }


    public void UpdateUsername(string _username)
    {
        username = _username;
    }
    public void UpdatePassword(string _password)
    {
        password = _password;
    }
   

    public void SignIn()
    {
        UserAccount.Instance.SignIn(username, password);
    }
}
