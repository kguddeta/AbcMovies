using AbcMovies.Models;
using System.Collections.Generic;

namespace AbcMovies.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}