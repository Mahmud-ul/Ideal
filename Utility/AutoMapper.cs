using AutoMapper;
using Ideal.Model.Models;
using Ideal.Models.ViewModels;
using System.Diagnostics;

namespace Ideal.Utility
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Sample, SampleViewModel>();
            CreateMap<SampleViewModel, Sample>();
        }
    }
}
