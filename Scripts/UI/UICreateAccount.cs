using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICreateAccount : MonoBehaviour
{
    [SerializeField] Text errorText;
    [SerializeField] Canvas canvas;
    string username, password, emailaddress;

    void OnEnable()
    {
        UserAccount.OnCreateAccountFailed.AddListener(OnCreateAccountFailed);
    }

    void OnDisable()
    {
        UserAccount.OnCreateAccountFailed.RemoveListener(OnCreateAccountFailed);
    }
    void OnCreateAccountFailed (string error)
    {
        errorText.gameObject.SetActive(true);
        errorText.text = error;
    }

    void OnSignInSuccess()
    {
        canvas.enabled = true;
    }

    public void UpdateUsername ( string _username)
    {
        username = _username;
    }
    public void UpdatePassword(string _password)
    {
        password = _password;
    }
    public void UpdateEmailAddress(string _emailaddress)
    {
        emailaddress = _emailaddress;
    }

    public void CreateAccount()
    {
        UserAccount.Instance.CreateAccount(username, emailaddress, password);
    }
}
