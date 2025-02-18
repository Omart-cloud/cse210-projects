using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string _name;
    protected int _points;
    
    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
    }
    
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public int GetPoints() => _points;
}