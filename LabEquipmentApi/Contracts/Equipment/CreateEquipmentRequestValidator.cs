using FluentValidation;

namespace LabEquipmentApi.Contracts.Equipment
{
    public class CreateEquipmentRequestValidator : AbstractValidator<CreateEquipmentRequest>
    {
        public CreateEquipmentRequestValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty()
                .MaximumLength(100);
            RuleFor(e => e.Room)
                .NotEmpty()
                .MaximumLength(20);
        }
    }
}
