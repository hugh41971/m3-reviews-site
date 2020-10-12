﻿using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Repositories
{
    public class RestaurantRepository
    {
        public List<Restaurant> restaurantList;
        public RestaurantRepository()
        {
            restaurantList = new List<Restaurant>()
            {
                new Restaurant(1, ""),
                new Restaurant(2, ""),
                new Restaurant(3, "")
            }
        }

    }
}
