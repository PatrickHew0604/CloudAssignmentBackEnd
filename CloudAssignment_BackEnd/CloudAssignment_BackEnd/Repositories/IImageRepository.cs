using CloudAssignment_BackEnd.Models.Domain;

namespace CloudAssignment_BackEnd.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
