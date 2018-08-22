﻿using FirstWebApp.Models;
using System.Collections.Generic;

namespace FirstWebApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }

    }
}
