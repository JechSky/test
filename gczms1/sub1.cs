﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gczms1
{
    class sub1 : Subject
    {
        List<Observer> list = new List<Observer>();
        public void AmiAt(Observer obs)
        {
            list.Add(obs);
        }

        public void Notify()
        {
            foreach (Observer item in list)
            {
                item.Response();
            }
        }

    }
}
