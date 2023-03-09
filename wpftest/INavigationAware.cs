﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpftest
{
    public interface INavigationAware
    {
        void OnNavigating(object sender, object navigationEventArgs);
        void OnNavigated(object sender, object navigatedEventArgs);
    }
}
