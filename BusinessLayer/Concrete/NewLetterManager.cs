using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewLetterManager : INewsLetterService
    {
        INewsLetterDal _newLetterDal;

        public NewLetterManager(INewsLetterDal newLetterDal)
        {
            _newLetterDal = newLetterDal;
        }

        public void AddNewsLetter(NewsLetter cls_newsLetter)
        {
            _newLetterDal.Insert(cls_newsLetter);
        }
    }
}
