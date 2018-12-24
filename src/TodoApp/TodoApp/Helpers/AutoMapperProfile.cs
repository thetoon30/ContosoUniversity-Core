using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Entities;
using TodoApp.Models;

namespace TodoApp.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserModel, User>();
            CreateMap<User, UserModel>();
        }
    }
}
