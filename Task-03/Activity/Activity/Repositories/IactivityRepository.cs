using Activity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity.Repositories
{
    public interface IactivityRepository
    {

        Task<IEnumerable<activity>> Get();
        Task<activity> Get(Guid id);

        Task<activity> Create(activity activity);


    }
}

