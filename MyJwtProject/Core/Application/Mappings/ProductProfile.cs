using AutoMapper;
using MyJwtProject.Core.Application.Dtos;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Mappings
{
	public class ProductProfile:Profile
	{
		public ProductProfile()
		{
			this.CreateMap<Product,ProductListDto>().ReverseMap();
		}
	}
}
