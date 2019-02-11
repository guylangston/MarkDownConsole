﻿using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ConsoleZ.Web
{
   
    // DTO
    public class ConsoleData
    {
        // Meta
        public string Handle { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Version { get; set; }

        // Output / Render
        public string HtmlContent { get; set; }

        // State
        public bool IsActive { get; set; }
        public string UpdateUrl { get; set; }
       

        // Navigation
        public string DoneUrl { get; set; }
        public string BackUrl { get; set; }
        public string CancelUrl { get; set; }

        public Dictionary<string, string> Props { get; set; }
    }
}