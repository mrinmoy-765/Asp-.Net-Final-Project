using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static List<EmployeeDTO> GetCouriers()
        {
            var data = DataAccessFactory.CourierDataAccess().GetAll();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<EmployeeDTO>>(data);
        }
        public static EmployeeDTO GetCourier(int id)
        {
            var data = DataAccessFactory.CourierDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Employee, EmployeeDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<EmployeeDTO>(data);
        }
        public static bool DeleteCourier(int id)
        {
            return DataAccessFactory.CourierDataAccess().Delete(id);
        }
        public static bool AddCourier(EmployeeDTO Data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(config);
            var value = mapper.Map<Employee>(Data);
            return DataAccessFactory.CourierDataAccess().Add(value);
        }
        public static bool CourierUpdate(EmployeeDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<EmployeeDTO, Employee>();
            });
            var mapper = new Mapper(config);
            var value = mapper.Map<Employee>(data);
            return DataAccessFactory.CourierDataAccess().Update(value);
        }
    }
}
