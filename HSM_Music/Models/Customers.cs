using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSM_Music.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool isSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}