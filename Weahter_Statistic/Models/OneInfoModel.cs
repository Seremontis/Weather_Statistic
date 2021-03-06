﻿using System;
using System.Collections.Generic;


namespace Weather_Statistic.Models
{
    // Direct wind
    public enum Direction
    {
        brak,
        N,
        NE,
        E,
        SE,
        S,
        SW,
        W,
        NW
    }

    //Type length visible
    public enum Leng
    {
        m,
        km,
    }

    //Model primary
    public class OneInfoModel
    {
        public Int32 Day { get; set; }
        public string TypeWeat { get; set; }
        public string Place { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public float MaxTemp { get; set; }
        public float MinTemp { get; set; }
        public float Pressure { get; set; }
        public int Humadity { get; set; }
        public int Cloudy { get; set; }
        public float Rainfall { get; set; }
        public float Windspeed { get; set; }
        public Direction Direct { get; set; }
        public float DirectNumber { get; set; }
        public float Visible { get; set; }
        public Leng TypeLeng { get; set; }
        public List<int> SunriseTime { get; set; }
        public List<int> SunsetTime { get; set; }
    }
}
