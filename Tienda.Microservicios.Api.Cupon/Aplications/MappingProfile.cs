﻿using AutoMapper;
using Tienda.Microservicios.Api.Cupon.Models.Dto;

namespace Tienda.Microservicios.Api.Cupon.Aplications
{
    public class MappingProfile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<CuponDto, Cupon.Models.Cupon>();
                    config.CreateMap<Cupon.Models.Cupon, CuponDto>();
                });

            return mappingConfig;
        }
    }
}
