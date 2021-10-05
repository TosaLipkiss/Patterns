using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPlayerNames : MonoBehaviour
{
    delegate int ScoreDelegate(PlayerStats stats);
    void OnGameOver(PlayerStats[] allPlayerStats)
    {
        string playerNameMostKills = GetPlayerNameTopScore(allPlayerStats, stats => stats.kills);
        string playerNameMostFlagCaptured = GetPlayerNameTopScore(allPlayerStats, stats => stats.flagCaptured);
    }

/*    int ScoreByKillcount(PlayerStats stats)
    {
        return stats.kills;
    }

    int ScoreByFlagCaptures(PlayerStats stats)
    {
        return stats.flagCaptured;
    }*/

    string GetPlayerNameTopScore(PlayerStats[] allPlayerStats, ScoreDelegate scoreCalc)
    {
        string name = "";
        int bestScore = 0;

        foreach(PlayerStats stats in allPlayerStats)
        {
            int score = scoreCalc(stats);

            if(score > bestScore)
            {
                bestScore = score;
                name = stats.name;
            }
        }

        return name;
    }
}
