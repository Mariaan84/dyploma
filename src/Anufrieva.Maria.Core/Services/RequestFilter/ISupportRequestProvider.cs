using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Anufrieva.Marria.Core.Models;

namespace Anufrieva.Marria.Core.Services.RequestFilter
{
    public interface ISupportRequestProvider
    {
        public IEnumerable<SupportRequest> Get();

        public void Add(SupportRequest request);
    }
}