﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInsturctorService
    {
        IDataResult<List<Instructor>> GetAll();
        IDataResult<Instructor> GetById(int id);
        IResult Add(Instructor instructor);
        IResult Delete(Instructor instructor);
        IResult Update(Instructor instructor);
    }
}
