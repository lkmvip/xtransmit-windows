﻿using System;

namespace XTransmit.Model.UserAgent
{
    [Serializable]
    public class UAProfile
    {
        public string OS { get; set; }
        public string Client { get; set; }
        public string Value { get; set; }

        public UAProfile()
        {
            OS = "Windows 10";
            Client = "Chrome";
            Value = "";
        }
    }
}
