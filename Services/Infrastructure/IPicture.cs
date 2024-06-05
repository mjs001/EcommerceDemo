using ecommerceWithAngular.Models;

namespace ecommerceWithAngular.Services.Infrastructure
{
    public interface IPicture
    {
        Picture GetPicture(int id);
        void Insert(Picture picture);
        void Update(Picture picture);
        void Delete(int id);
        void Save();
    }
}
