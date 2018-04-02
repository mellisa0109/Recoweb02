using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecoWeb.Domain.Abstract;
using System.Data.Entity.Core.Objects;

namespace RecoWeb.Domain.Concrete
{
    public class MesEntityRepository : IMesEntityRepository
    {
        private RecowebdbEntities context = new RecowebdbEntities();     

        public IEnumerable<COW_MenuListByJsonInquiry_Result> COW_MenuListByJsonInquiry(){
            return context.COW_MenuListByJsonInquiry(); 
        }
        

        public int PRW_EmployeeSave(string id,string password, string name, string email, string phonenumber, ObjectParameter outmessage)
        {
            return context.PRW_EmployeeSave(id, password, name, email, phonenumber, outmessage);
        }

        public IEnumerable<COW_DataStackInquiry_Result> COW_DataStackInquiry(string code)
        {
            return context.COW_DataStackInquiry(code);
        }

        public void COW_AuthenticateInquiry(string id, string password, ObjectParameter outResult, ObjectParameter outMessage)
        {
            context.COW_AuthenticateInquiry(id, password, outResult, outMessage);
        }

        public IEnumerable<PRW_PlantInquiry_Result> PRW_PlantInquiry()
        {
            return context.PRW_PlantInquiry();
        }

        public IEnumerable<PRW_EmployeeInquiry_Result> PRW_EmployeeInquiry(string category)
        {
            return context.PRW_EmployeeInquiry(category);
        }
    }
}
