﻿using PetShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.IRepositories
{
    public interface IPetRepository: IGenericRepository<Pet>
    {
        Pet GetByIdJoined(int id);
    }
}
