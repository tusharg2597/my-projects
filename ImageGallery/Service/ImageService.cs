using ImageGallery.Models;
using System.Collections.Generic;

namespace ImageGallery.Service
{
    public interface ImageService
    {
         List<ImageModel> GetAllImages();
    }
}
