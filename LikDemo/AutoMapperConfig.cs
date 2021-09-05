using AutoMapper;
using LikDemo.Models;
using LikDemo.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikDemo
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<InvoiceResource, InvoiceViewModel>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Type, opt => opt.MapFrom(s => s.Type))
                .ForMember(d => d.Date, opt => opt.MapFrom(s => s.Attributes.Date))
                .ForMember(d => d.NetAmount, opt => opt.MapFrom(s => s.Attributes.NetAmount))
                .ForMember(d => d.Currency, opt => opt.MapFrom(s => s.Attributes.Currency))
                .ForMember(d => d.DueDate, opt => opt.MapFrom(s => s.Attributes.DueDate));
        }
    }
}
