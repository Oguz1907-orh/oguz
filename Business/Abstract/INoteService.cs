using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface INoteService
    {
        IDataResult<List<Note>> GetAll();
        IDataResult<Note> GetById(int id);
        IResult Add(Note note);
        IResult Delete(Note note);
        IResult Update(Note note);
    }
}
