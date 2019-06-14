﻿using System;

namespace HireTrailer.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastRented { get; set; }
        public bool IsRenting { get; set; }
    }
}