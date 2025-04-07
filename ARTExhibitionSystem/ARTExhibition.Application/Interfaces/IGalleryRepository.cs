using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;

namespace ARTExhibition.Application.Interfaces
{
    public interface IGalleryRepository
    {
        Task<IEnumerable<Gallery>> GetAllGalleriesAsync();
        Task<Gallery> GetGalleryByIdAsync(int id);
        Task<Gallery> AddGalleryAsync(Gallery gallery);
        Task UpdateGalleryAsync(Gallery gallery);
        Task DeleteGalleryAsync(int id);
    }
}
