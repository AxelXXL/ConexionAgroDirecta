using AutoMapper;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tbl_Categoria;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria
{
    public class CreateCategoriaCommand : ICreateCategoriaCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateCategoriaCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreateCategoriaModel> Execute(CreateCategoriaModel model)
        {
            var entity = _mapper.Map<Tb_CategoriaEntity>(model);
            await _dataBaseService.Tb_Categoria.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}
