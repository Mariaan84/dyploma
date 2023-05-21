using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anufrieva.Marria.Core.Models;

namespace Anufrieva.Marria.Core.Services.RequestFilter
{
    public sealed class SupportRequestProvider : ISupportRequestProvider
    {
        private readonly List<SupportRequest> _supportRequests = new List<SupportRequest>
        {
            new SupportRequest
            {
                Title = "Clothers for a newborn",
                Date = DateTime.Now,
                Description = "I have a new family member, so would be appreciate"
                              +  " if you could provide me some stuff," 
                              + "so I can support this little baby.",
                User = new User
                {
                    Name = "Hubert Hend",
                    Age = "15 years",
                    City = "New Mexico"
                }
            },
            new SupportRequest
            {
                Title = "Nurofen for kids (syrop)",
                Date = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
                Description = "I have 2 cans of nurofen for kids." 
                              + " I will sship it or pick up it yourself in Kyiv.",
                User = new User
                {
                    Name = "Vladislav Nikolenko",
                    Age = "In secrecy",
                    City = "Kyiv"
                }
            },
            new SupportRequest
            {
                Title = "Insulin for diabetics",
                Date = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                Description = "Insulin urgently needed for older people with diabetes.",
                User = new User
                {
                    Name = "Antonina Petrenko",
                    Age = "In secrecy",
                    City = "Chernivtsi"
                }
            },
            new SupportRequest
            {
                Title = "Сardiac medicines",
                Date = DateTime.Now.Subtract(TimeSpan.FromDays(3)),
                Description = "I need medication for an older woman. I will be grateful for your help!",
                User = new User
                {
                    Name = "Viktor Kyslynych",
                    Age = "36 years",
                    City = "Lviv"
                }
            }
        };

        public IEnumerable<SupportRequest> Get() =>
            _supportRequests;

        public void Add(SupportRequest request) =>
            _supportRequests.Add(request);
    }
}