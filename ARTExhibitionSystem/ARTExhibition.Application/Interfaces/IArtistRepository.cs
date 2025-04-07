using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARTExhibitionSystem.Domain.Entities;

namespace ARTExhibition.Application.Interfaces;

public interface IArtistRepository
{
    Task<IEnumerable<Artist>> GetAllArtistsAsync();
    Task<Artist> GetArtistByIdAsync(int id);
    Task<int> AddArtist(Artist artist);
    Task UpdateArtistAsync(Artist artist);
    Task<bool> DeleteArtistAsync(int id);
    //Task<Artist> AddArtistAsync(object artist);
}
