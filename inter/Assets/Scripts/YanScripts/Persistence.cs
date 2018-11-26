using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YanScripts;

public static class Persistence
{
    public static int Mask;
    public static int Quest;
    public static int Pesquisa;
    public static int Day;
    public static int Senha;
    public static bool HaveASave;
    public static string NextLevel;

    public static void SavaData()
    {
        HaveASave = true;
        PlayerPrefs.SetInt("Mask",Mask);
        PlayerPrefs.SetInt("Quest", Quest);
        PlayerPrefs.SetInt("Senha", Senha);
        PlayerPrefs.SetInt("Pesquisa", Pesquisa);
        PlayerPrefs.SetInt("Day", Day);
        PlayerPrefsX.SetBool("HaveASave", HaveASave);
        PlayerPrefs.SetInt("NReds", PickUp.NReds);
        PlayerPrefs.SetInt("NBlues", PickUp.NBlues);
        PlayerPrefs.SetInt("NGreens", PickUp.NGreens);
    }

    public static void LoadData()
    {
        Mask = PlayerPrefs.GetInt("Mask");
        Quest = PlayerPrefs.GetInt("Quest");
        Senha = PlayerPrefs.GetInt("Senha");
        HaveASave = PlayerPrefsX.GetBool("HaveASave");
        Pesquisa = PlayerPrefs.GetInt("Pesquisa");
        Day = PlayerPrefs.GetInt("Day");
        PickUp.NReds = PlayerPrefs.GetInt("NReds");
        PickUp.NBlues = PlayerPrefs.GetInt("NBlues");
        PickUp.NGreens = PlayerPrefs.GetInt("NGreens");
    }

    public static void ReturnValues()
    {
        PlayerPrefs.DeleteAll();
        Quest = 0;
        Day = 0;
        Mask = 0;
        Senha = 0;
        Pesquisa = 0;
        HaveASave = false;
        PickUp.NReds = 0;
        PickUp.NBlues = 0;
        PickUp.NGreens = 0;

    }
}