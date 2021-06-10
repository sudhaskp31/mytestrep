﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface IRepo
    {
         void Add(Patient patien);
         void Delete(int Id);
         Patient Get(int Id);
         IList<Patient> GetAll();
        void Update(int ID);

    }
}
