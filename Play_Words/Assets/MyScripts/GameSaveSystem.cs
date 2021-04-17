using UnityEngine;

public class GameSaveSystem : MonoBehaviour
{
    public static GameSaveSystem Instans;
    private  const string Email = "EMAIL";
    private  const string Name = "Name";
    private  const string Password = "PASSWORD";
    private  const string userToken = "USERTOKEN";
    private const string LoginBefore = "LOGINBEFORE";
    private const string Xp="XP";
    private const string Coin = "COIN";
    private const string Cup = "CUP";
    public bool lunchTheApp;
    private void Awake()
    {
        SingelTon();
    }

    public void SingelTon()
    {
        
        if (Instans != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instans = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("FirstTime"))
        {
            
            PlayerPrefs.SetString(Email,null);
            PlayerPrefs.SetString(Name,null);
            PlayerPrefs.SetString(Password,null);
            PlayerPrefs.SetString(userToken,"not");
            PlayerPrefs.SetInt(LoginBefore,0);
            PlayerPrefs.SetInt(Coin,300);
            PlayerPrefs.SetInt(Xp,0);
            PlayerPrefs.SetInt(Cup,0);
            PlayerPrefs.SetInt("FirstTime",1);
            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetEmail(string email)
    {
        PlayerPrefs.SetString(Email,email);

    }

    public string GetEmail()
    {
        return PlayerPrefs.GetString(Email);
    }

    public void SetPassword(string password)
    {
        PlayerPrefs.SetString(Password,password);
    }

    public string GetPassword()
    {
        return  PlayerPrefs.GetString(Password);
    }

    public void SetUserToken(string usertoken)
    {
        PlayerPrefs.SetString(userToken,usertoken);
    }

    public string GetUserToken()
    {
        return    PlayerPrefs.GetString(userToken);

    }

    public void SetLoginBefore(int loginBefore)
    {
        PlayerPrefs.SetInt(LoginBefore,loginBefore);
    }

    private int GetLoginBefore()
    {
       return PlayerPrefs.GetInt(LoginBefore);
    }

    public void SetCoin(int coin)
    {
        PlayerPrefs.SetInt(Coin,coin);
    }

    public int GetCoin()
    {
        return PlayerPrefs.GetInt(Coin);
    }

    public void SetXp(int xp)
    {
        PlayerPrefs.SetInt(Xp,xp);
    }

    public int GetXp()
    {
        return PlayerPrefs.GetInt(Xp);
    }

    public void SetCup(int cup)
    {
        PlayerPrefs.SetInt(Cup,cup);

    }

    public int GetCup()
    {
        return PlayerPrefs.GetInt(Cup);

    }

    public void SetName(string UserName)
    {
        PlayerPrefs.SetString(Name,UserName);
    }

    public string GetName()
    {
        return PlayerPrefs.GetString(Name);
    }

    public bool IsLoginBefore()
    {
        if (GetLoginBefore() == 0)
        {
            return false;
        }
        else   
        {
            return true;
        }
       
    }
    
   
 }

