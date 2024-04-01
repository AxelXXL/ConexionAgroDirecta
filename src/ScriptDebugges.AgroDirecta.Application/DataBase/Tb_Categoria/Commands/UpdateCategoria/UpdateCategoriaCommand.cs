using AutoMapper;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.UpdateCategoria
{
    public class UpdateCategoriaCommand : IUpdateCategoriaCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public UpdateCategoriaCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<UpdateCategoriaModel> Execute(UpdateCategoriaModel model)
        {
            var entity = _mapper.Map<Tb_CategoriaEntity>(model);
            _dataBaseService.Tb_Categoria.Update(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
