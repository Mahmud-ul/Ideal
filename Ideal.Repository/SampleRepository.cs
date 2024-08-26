using Ideal.Model.Models;
using Ideal.Repository.Base;
using Ideal.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Repository
{
    public class SampleRepository : BaseRepository<Sample>, ISampleRepository
    {
    }
}
