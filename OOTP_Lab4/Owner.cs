using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab4
{
    class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Organization { get; set; }
        public Owner(int id, string name, string organization)
        {
            this.Id = id;
            this.Name = name;
            this.Organization = organization;
        }
    }
}
