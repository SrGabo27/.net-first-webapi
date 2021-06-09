using AutoMapper;
using first_app.Domain.Models;
using first_app.Resources;

namespace first_app.Mapping
{
    public class ModelToResourceProfile: Profile 
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
