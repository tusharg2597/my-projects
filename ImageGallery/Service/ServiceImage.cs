using ImageGallery.Models;
using ImageGallery.Repository;
using System.Collections.Generic;

namespace ImageGallery.Service
{
    public class ServiceImage : ImageService
    {
        public List<ImageModel> GetAllImages()
        {
            return ImageRepository.GetImages();
        }
    }
}
