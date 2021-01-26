using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fair_Radio
{
    class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
