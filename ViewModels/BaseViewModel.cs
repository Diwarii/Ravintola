﻿using Ravintola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravintola.ViewModels
{
    public class BaseViewModel : Property
    {
        public BaseViewModel()
        {
            Global.db = new ApplicationContext();
        }
    }
}
