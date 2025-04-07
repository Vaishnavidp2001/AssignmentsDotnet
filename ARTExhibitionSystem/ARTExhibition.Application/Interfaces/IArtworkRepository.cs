using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;

namespace ARTExhibition.Application.Interfaces
{
    public interface IArtworkRepository
    {
        Task<IEnumerable<Artwork>> GetAllArtworksAsync();
        Task<Artwork> GetArtworkByIdAsync(int id);
        Task<Artwork> AddArtworkAsync(Artwork artwork);
        Task UpdateArtworkAsync(Artwork artwork);
        Task<bool> DeleteArtworkAsync(int id);
        //Task<Artwork> AddAsync(Artwork artwork);
        //Task<IEnumerable<Artwork>> GetAllAsync();
        //Task<Artwork> AddAsync(object artwork);
    }
}
