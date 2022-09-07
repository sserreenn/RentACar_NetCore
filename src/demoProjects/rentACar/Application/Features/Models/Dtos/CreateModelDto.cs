using Domain.Entities;

namespace Application.Features.Models.Dtos
{
    public class CreateModelDto
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
        public virtual Brand? Brand { get; set; }
    }
}
