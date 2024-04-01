using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Queries.GetAllCategoria
{
    public class GetAllCategoriaQuery : IGetAllCategoriaQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public GetAllCategoriaQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<List<GetAllCategoriaModel>> Execute()
        {
            var listEntity = await _dataBaseService.Tb_Categoria.ToListAsync();
            return _mapper.Map<List<GetAllCategoriaModel>>(listEntity);
        }
    }
}
