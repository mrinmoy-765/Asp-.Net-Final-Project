using AutoMapper;
using BLL.DTO;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static List<AdminDTO> GetAdmins()
        {
            var data = DataAccessFactory.AdminDataAccess().GetAll();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<AdminDTO>>(data);
        }

        public static List<EmployeeDTO> GetEmployees()
        {
            var data = DataAccessFactory.EmployeeDataAccess().GetAllEmployees();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<EmployeeDTO>>(data);
        }
        public static AdminDTO GetAdmin(int id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<AdminDTO>(data);
        }
        public static bool DeleteAdmin(int id)
        {
            return DataAccessFactory.AdminDataAccess().Delete(id);
        }
        public static bool AddAdmin(AdminDTO Data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var value = mapper.Map<Admin>(Data);
            return DataAccessFactory.AdminDataAccess().Add(value);
        }
        public static bool AdminUpdate(AdminDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var value = mapper.Map<Admin>(data);
            return DataAccessFactory.AdminDataAccess().Update(value);
        }
    }
}
