﻿using System.Drawing;
using ChessGame.Model;

namespace ChessGame.Data;

public class Information
{
    public bool PlayAgainstAi { get; set; }
    public Team CurrentTeam { get; set; }
    public Point WhiteKingLocation { get; set; } 
    public Point BlackKingLocation { get; set; } 
    public bool HasWhiteKingEverMoved { get; set; }
    public bool HasBlackKingEverMoved { get; set; }

    public Information()
    {
        WhiteKingLocation = new Point(4, 7);
        BlackKingLocation = new Point(4, 0);
        HasBlackKingEverMoved = false;
        HasWhiteKingEverMoved = false;

    }

    public void UpdateKingEverMoved()
    {
        if (CurrentTeam == Team.White)
            HasWhiteKingEverMoved = true;
        
        else
            HasBlackKingEverMoved = true;
    }

    public bool HasMyKingMovedBefore()
    {
        return CurrentTeam == Team.White ? HasWhiteKingEverMoved : HasBlackKingEverMoved;
    }

    public Point GetMyKingLocation()
    {
        return CurrentTeam == Team.White ? WhiteKingLocation : BlackKingLocation;
    }
    public void UpdateKingLocation(int x, int y)
    {
        if (CurrentTeam == Team.White)
        {
            var whiteKingLocation = WhiteKingLocation;
            whiteKingLocation.X = x;
            whiteKingLocation.Y = y;
        }
        else
        {
            var blackKingLocation = BlackKingLocation;
            blackKingLocation.X = x;
            blackKingLocation.Y = y;
        }
    }
}