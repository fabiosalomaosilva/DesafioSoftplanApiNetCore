using AutoMapper;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DesafioSoftplan.Services.Services
{
    public class ServiceBase
    {
        protected readonly IMapper _mapper;
        protected readonly HttpClient _client;

        public ServiceBase(IMapper mapper)
        {
            _mapper = mapper;
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://restcountries.com/")
            };
        }
    }
}
