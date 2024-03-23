﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore.Dtos;
using TechStore.Dtos.ProductDtos;
using TechStore.Models;
using TechStore.Dtos.UserDTO;
using TechStore.Dtos.CategoryDtos;
using TechStore.Dtos.AccountDtos;
using Microsoft.AspNetCore.Identity;
using TechStore.Dtos.ReviewDtos;


namespace TechStore.Application.Mapper
{
    internal class AutoMapperProfile :Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<UpdateUserDTO, TechUser>().ReverseMap();
            CreateMap<GetAllUserDTO, TechUser>().ReverseMap();
            CreateMap<LoginDto, TechUser>().ReverseMap();
            CreateMap<RegisterDto, TechUser>().ReverseMap();



            CreateMap<CreateOrUpdateProductDtos, Product>().ReverseMap();
            CreateMap<SpecificationsDto, Specification>().ReverseMap();
               


            //productitem
            CreateMap<LabtopItemDtos, Specification>().ReverseMap();
            CreateMap<MobileAndTabletItemDtos, Specification>().ReverseMap();
            CreateMap<ScreenItemDtos, Specification>().ReverseMap();
            CreateMap<SmartwatchItemDtos, Specification>().ReverseMap();
            CreateMap<GetAllProductsDtos, Product>().ReverseMap();
            CreateMap<GetAllProductsForUserDto, Product>().ReverseMap();

            CreateMap<RegisterDto, TechUser>().ReverseMap();
            CreateMap<LoginDto, TechUser>().ReverseMap();
            CreateMap<UserDto, TechUser>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CreateOrUpdateReviewDto, Review>().ReverseMap();
            CreateMap<GetAllReviewDto, Review>().ReverseMap();


            

        }
    }
}
