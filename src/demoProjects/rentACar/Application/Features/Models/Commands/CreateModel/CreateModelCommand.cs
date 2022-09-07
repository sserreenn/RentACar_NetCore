using Application.Features.Models.Dtos;
using MediatR;

namespace Application.Features.Models.Commands.CreateModel
{
    public class CreateModelCommand :IRequest<CreateModelDto>
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
        public virtual Brand? Brand { get; set; }
    }
}
