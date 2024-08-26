using Ideal.Manager.Base;
using Ideal.Manager.Contract;
using Ideal.Model.Models;
using Ideal.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideal.Manager
{
    public class SampleManager : BaseManager<Sample>, ISampleManager
    {
        private readonly ISampleRepository _sampleRepository;
        public SampleManager(ISampleRepository sampleRepository) : base(sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }
    }
}
