using ImageGallery.Service;
using Microsoft.AspNetCore.Mvc;

namespace ImageGallery.Controllers
{
    public class ImageController : Controller
    {


        private readonly ImageService _imageService;

        public ImageController(ImageService imageService)
        {
            _imageService = imageService;
        }


        public IActionResult Index()
        {
            var images=_imageService.GetAllImages();
            return View(images);
        }
    }
}
