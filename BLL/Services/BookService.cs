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
    public class BookService
    {
        public static List<BookDTO> GetItems()
        {
            var data = DataAccessFactory.ItemDataAccess().GetAll();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<BookDTO>>(data);
        }
        public static BookDTO GetItem(int id)
        {
            var data = DataAccessFactory.ItemDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<BookDTO>(data);
        }
        public static bool DeleteItem(int id)
        {
            return DataAccessFactory.ItemDataAccess().Delete(id);
        }
        public static bool AddItem(BookDTO Data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<BookDTO, Book>();
            });
            var mapper = new Mapper(config);
            var value = mapper.Map<Book>(Data);
            return DataAccessFactory.ItemDataAccess().Add(value);
        }
        public static bool ItemUpdate(BookDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<BookDTO, Book>();
            });
            var mapper = new Mapper(config);
            var value = mapper.Map<Book>(data);
            return DataAccessFactory.ItemDataAccess().Update(value);
        }
    }
}
