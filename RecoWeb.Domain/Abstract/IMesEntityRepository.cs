using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecoWeb.Domain.Concrete;
using System.Data.Entity.Core.Objects;

namespace RecoWeb.Domain.Abstract
{
    public interface IMesEntityRepository
    {
        IEnumerable<COW_MenuListByJsonInquiry_Result> COW_MenuListByJsonInquiry();

        int PRW_EmployeeSave(string id, string password, string name, string email, string phonenumber, ObjectParameter outmessage);

        IEnumerable<COW_DataStackInquiry_Result> COW_DataStackInquiry(string code);

        void COW_AuthenticateInquiry(string id, string password, ObjectParameter outResult, ObjectParameter outMessage);

        IEnumerable<PRW_PlantInquiry_Result> PRW_PlantInquiry();

        IEnumerable<PRW_EmployeeInquiry_Result> PRW_EmployeeInquiry(string category);
    }
}
