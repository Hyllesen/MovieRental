using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRental.Models;
using Vidly.Models;

namespace MovieRental.ViewModels
{
    public class customerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}