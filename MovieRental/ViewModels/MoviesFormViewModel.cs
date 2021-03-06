﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace MovieRental.ViewModels
{
    public class MoviesFormViewModel
    {
        public Movie Movie { get; set; }
        public List<Genres> Genres { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }
}