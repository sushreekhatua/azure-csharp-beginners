﻿using GreetingService.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingService.Core.Interfaces
{
    public interface IGreetingRepository
    {
        public Task<Greeting> GetAsync(Guid id);
        public Task<IEnumerable<Greeting>> GetAsync();
        public Task<IEnumerable<Greeting>> GetAsync(string from, string to);
        public Task CreateAsync(Greeting greeting);
        public Task UpdateAsync(Greeting greeting);

    }
}
