﻿using AutoMapper;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Productos.Commands.CreateProductos;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Producto;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_UnidadMedida;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_UnidadMedida.Commands.Create
{
    public class CreateUnidadMedidaCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public CreateUnidadMedidaCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateUnidadMedidaModel> Execute(CreateUnidadMedidaModel model)
        {
            var entity = _mapper.Map<Tb_UnidadMedidaEntity>(model);
            await _dataBaseService.Tb_UnidadMedida.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }


    }
}
