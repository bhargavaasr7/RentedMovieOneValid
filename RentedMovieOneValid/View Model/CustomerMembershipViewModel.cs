using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentedMovieOneValid.Models;

namespace RentedMovieOneValid.View_Model
{
    public class CustomerMembershipViewModel
    {
        public Customer Customer{ get; set; }
        public List<MembershipType> membershipTypes { get; set; }
    }
}