using AutoMapper;
using ScriptDebugges.AgroDirecta.Domain.Entities.Tb_Usuario;

namespace ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Usuario.Commands.CreateUser
{
    public class CreateUserQuery : ICreateUserQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreateUserQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<bool> Execute(CreateUserModelResponse newUser)
        {
            if(newUser.ConfirmarContrasena != newUser.Contrasena)
                return false;

            var entity = _mapper.Map<Tb_UsuarioEntity>(newUser);
            await _dataBaseService.Tb_Usuario.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return false;
        }
    }
}
