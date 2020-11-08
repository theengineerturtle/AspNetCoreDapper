﻿using Domain.Entities;
using Domain.Interfaces.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Repositories
{
    public interface IBookDapperRepository : IRepositoryBase<Book>
    {
        //Custom Operations
    }
}
