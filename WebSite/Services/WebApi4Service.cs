﻿using CommonStructures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebSite.Services
{
    public class WebApi4Service : IWebApi4Service
    {
        public Task<IEnumerable<TC_Data>> LoadData()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TC_Data>> PostData()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TC_Data>> Search()
        {
            throw new System.NotImplementedException();
        }
    }
}