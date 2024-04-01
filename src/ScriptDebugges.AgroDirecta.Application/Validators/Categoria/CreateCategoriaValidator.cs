using FluentValidation;
using ScriptDebugges.AgroDirecta.Application.DataBase.Tb_Categoria.Commands.CreateCategoria;

namespace ScriptDebugges.AgroDirecta.Application.Validators.Categoria
{
    public class CreateCategoriaValidator : AbstractValidator<CreateCategoriaModel>
    {
        public CreateCategoriaValidator()
        {
            RuleFor(x => x.Categoria).NotNull().NotEmpty();
            RuleFor(x => x.Descripcion).NotNull().NotEmpty();
        }
    }
}
