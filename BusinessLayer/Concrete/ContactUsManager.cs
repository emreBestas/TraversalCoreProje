﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public ContactUs GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetListByContactUsByFalse()
        {
            return _contactUsDal.GetListByContactUsByFalse();
        }

        public List<ContactUs> TGetListByContactUsByTrue()
        {
            return _contactUsDal.GetListByContactUsByTrue();
        }

        public void TAdd(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs t)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetList()
        {
           return _contactUsDal.GetList();
        }

        public void TUpdate(ContactUs t)
        {
            throw new NotImplementedException();
        }
    }
}
