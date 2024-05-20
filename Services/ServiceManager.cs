﻿using AutoMapper;
using Entities.DataTransferObjects;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {   //?? Lazy loading yapabilmek için private IHouseService alıp, newlendikten sonra public olarak erişime açılır

        private readonly Lazy<IHouseService> _houseService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerService logger, IMapper mapper, IHouseLinks houseLinks)
        {
            _houseService = new Lazy<IHouseService>(() => new HouseManager(repositoryManager, logger, mapper, houseLinks));
        }
        public IHouseService HouseService => _houseService.Value; //controller buraya erişebilsin
    }
}
