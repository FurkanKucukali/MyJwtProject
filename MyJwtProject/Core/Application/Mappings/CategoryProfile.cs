using AutoMapper;
using MyJwtProject.Core.Application.Dtos;
using MyJwtProject.Core.Domain;

namespace MyJwtProject.Core.Application.Mappings
{
	public class CategoryProfile:Profile
	{
		public CategoryProfile()
		{
			this.CreateMap<Category,CategoryListDto>().ReverseMap();
		}
	}
}
