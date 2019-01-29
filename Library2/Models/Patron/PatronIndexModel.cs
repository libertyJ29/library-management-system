using System.Collections.Generic;

namespace Library2.Models.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronDetailModel> Patrons { get; set; }     //this will be returned to the patron index view
    }
}
